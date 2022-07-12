using Microsoft.AspNetCore.Mvc;

namespace SocialMedia.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        // private readonly IPostService _postService;

        // * POST a Post - required
        [HttpPost]
        public async Task<IActionResult> CreatePostAsync() {
            throw new NotImplementedException();
        }

        // * GET all Posts - required
        [HttpGet]
        public async Task<IActionResult> GetAllPostsAsync() {
            throw new NotImplementedException();
        }

        // GET Posts by author id
        // PUT Post
        // DELETE Post
    }
}