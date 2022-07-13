using Microsoft.AspNetCore.Mvc;
using SocialMedia.Services.User;
using SocialMedia.Models;
using SocialMedia.Models.User;

namespace SocialMedia.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service) {
            _service = service;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserRegister model) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            var registerResult = await _service.RegisterUserAsync(model);
            if (registerResult) {
                return Ok("User was registered.");
            }
            return BadRequest("User could not be registered.");
        }

        [HttpGet("{userId:int}")]
        public async Task<IActionResult> GetById([FromRoute] int userId) {
            var userDetail = await _service.GetUserByIdAsync(userId);
            if (userDetail is null) {
                return NotFound();
            }
            return Ok(userDetail);
        }
    }
}