using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PcGearHub.Data.DBModels;
using PcGearHub.Services.DTO;
using PcGearHub.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetById(id);
           

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

            // Delegate the creation responsibility to the service
            var user = await _userService.CreateUserFromDto(userDto);

            // Return a response with the new user's ID
            return CreatedAtAction(nameof(GetUserById), new { id = user.UserId }, user);
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

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            var existingUser = _userService.GetById(id);
            if (existingUser == null)
            {
                return NotFound();
            }

            await _userService.Delete(id);
            return NoContent();
        }
    }
}
