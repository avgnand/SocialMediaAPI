using Microsoft.AspNetCore.Mvc;

namespace SocialMedia.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        // private readonly ICommentService _commentService;

        // * POST Comment on a Post using Foreign Key - required
        [HttpPost]
        public async Task<IActionResult> CreateCommentAsync() {
            throw new NotImplementedException();
        }

        // * GET Comments by post id - required
        [HttpGet]
        public async Task<IActionResult> GetCommentsByIdAsync() {
            throw new NotImplementedException();
        }

        // GET Comments by author id
        // PUT Comment
        // DELETE Comment
    }
}