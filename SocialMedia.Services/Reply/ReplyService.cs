using SocialMedia.Data;

namespace SocialMedia.Services.Reply
{
    public class ReplyService : IReplyService
    {
        private readonly AppDbContext _context;
        public ReplyService(AppDbContext context) {
            _context = context;
        }
        // * POST Reply to a comment using Foreign Key - required
        public async Task<bool> CreateReplyAsync() {

        }

        // * GET Reply by comment id - required
        public async Task<> GetReplyByCommentIdAsync() {

        }

        // * GET Reply by author id
        // Task<> GetReplyByAuthorIdAsync() {

        // }

        // * PUT Update a reply
        // Task<bool> UpdateReplyAsync() {

        // }

        // * DELETE Delete a reply
        // Task<bool> DeleteReplyAsync() {

        // }
    }
}