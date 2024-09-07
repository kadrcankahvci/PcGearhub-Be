using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PcGearHub.Services.DTO;
using PcGearHub.Services.Interfaces;
using System.Security.Claims;

namespace PcGearHub.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserProfileController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserProfileController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]

        public async Task<ActionResult<UserDetailDTO>> GetUserProfile(int userId)
        {
            var userDetails = await _userService.GetUserDetails(userId);

            if (userDetails == null)
            {
                return NotFound("User not found.");
            }

            return Ok(userDetails);
        }

    }
}
