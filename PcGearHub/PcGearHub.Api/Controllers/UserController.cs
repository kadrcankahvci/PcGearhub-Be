using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PcGearHub.Data.DBModels;
using PcGearHub.Services.DTO;
using PcGearHub.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using PcGearHub.Services.ConvertDTO;

namespace PcGearHub.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var users = await _userService.GetAll();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public  async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetById(id);           

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult> CreateUser([FromBody] UserDTO userDto)
        {
            if (userDto == null)
            {
                return BadRequest("User data cannot be null.");
            }


            var user = await _userService.CreateUserFromDto(userDto);
            var lutfenolsun = Mapper.ToUserDTO(user);


            return CreatedAtAction(nameof(GetUserById), new { id = lutfenolsun.UserId }, lutfenolsun);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateUser(int id, [FromBody] User user)
        {
            if (id != user.UserId)
            {
                return BadRequest("ID mismatch");
            }

            var existingUser = _userService.GetById(id);
            if (existingUser == null)
            {
                return NotFound();
            }

            await _userService.Update(user);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            var existingUser = await _userService.GetById(id);
            if (existingUser == null)
            {
                return NotFound();
            }

            await _userService.Delete(id);
            return NoContent();
        }
        [HttpGet]
        public async Task<IActionResult> GetUserDetailsWithOrdersAndAddresses(int id)
        {
            var users = await _userService.GetAllIncluding(
                u => u.Addresses,
                u => u.Orders
            );

            var user = users.Find(u => u.UserId == id);

            if (user == null)
            {
                return NotFound("User not found.");
            }

            return Ok(user);
        }
    }
}
