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

        [HttpPost("Authenticate")]
        public async Task<ActionResult> Authenticate([FromBody] UserDTO userDto)
        {
            if (userDto == null || string.IsNullOrEmpty(userDto.Email) || string.IsNullOrEmpty(userDto.Password))
            {
                return BadRequest("Email and password are required.");
            }

            // Kullanıcıyı doğrula
            var user = await _userService.AuthenticateUser(userDto.Email, userDto.Password);

            if (user == null)
            {
                return Unauthorized("Invalid email or password.");
            }

            // Kullanıcı başarılı bir şekilde doğrulandı
            return Ok(new { message = "Login successful", user });
        }
    }
}
