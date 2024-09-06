using Microsoft.AspNetCore.Mvc;
using PcGearHub.Services.Interfaces;
using PcGearHub.Services.DTO;
using System.Threading.Tasks;

namespace PcGearHub.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<ActionResult> Authenticate([FromBody] UserLoginDTO userLoginDTO)
        {
            if (userLoginDTO == null || string.IsNullOrEmpty(userLoginDTO.Email) || string.IsNullOrEmpty(userLoginDTO.Password))
            {
                return BadRequest("Email and password are required.");
            }

            // Kullanıcıyı doğrula
            var user = await _userService.AuthenticateUser(userLoginDTO.Email, userLoginDTO.Password);

            if (user == null)
            {
                return Unauthorized("Invalid email or password.");
            }

            // Kullanıcı başarılı bir şekilde doğrulandı
            return Ok(new { message = "Login successful", user });
        }
    }
}
