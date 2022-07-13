using SocialMedia.Data;

namespace SocialMedia.Services.Post
{
    public class PostService : IPostService
    {
        private readonly AppDbContext _context;
        public PostService (AppDbContext context) {
            _context = context;
        }
        // * POST Create a post - required
        public async Task<bool> CreatePostAsync() {
               
        }

        // * GET All posts - required
        public async Task<> GetAllPostsAsync() {

        }

        // * GET Posts by author id
        // public Task<> GetPostsByAuthorIdAsync() {

        // }

        // * PUT Update a post
        // public async Task<bool> UpdatePostAsync() {

        // }

        // * DELETE Delete a Post
        // public async Task<bool> DeletePostAsync() {
            
        // }
    }
}