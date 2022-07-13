using SocialMedia.Data;

namespace SocialMedia.Services.Comment
{
    public class CommentService : ICommentService
    {
        private readonly AppDbContext _context;
        public CommentService (AppDbContext context) {
            _context = context;
        }
        // * POST Create a comment - required
        public async Task<bool> CreateCommentAsync() {

        }

        // * GET Comment by post id - required
        public async Task<> GetCommentByPostIdAsync() {

        }

        // * GET Comment by author id
        // public async Task<> GetCommentByAuthorIdAsync() {

        // }

        // * PUT Update a comment
        // public async Task<bool> UpdateCommentAsync() {

        // }

        // * DELETE Delete a comment
        // public async Task<bool> DeleteCommentAsync() {

        // }
    }
}