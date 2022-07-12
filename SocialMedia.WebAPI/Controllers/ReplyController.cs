using Microsoft.AspNetCore.Mvc;

namespace SocialMedia.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReplyController : ControllerBase
    {
        // private readonly IReplyService _replyService;

        // * POST Reply to a Comment using Foreign Key - required
        [HttpPost]
        public async Task<IActionResult> CreateReplyAsync() {
            throw new NotImplementedException();
        }

        // * GET Replies by comment id - required
        [HttpGet]
        public async Task<IActionResult> GetAllRepliesAsync() {
            throw new NotImplementedException();
        }

        // GET Reply by author id
        // PUT Reply
        // DELETE Reply
    }
}