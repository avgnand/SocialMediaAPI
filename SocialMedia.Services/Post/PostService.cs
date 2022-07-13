using SocialMedia.Data;

namespace SocialMedia.Services.Post
{
    public class PostService : IPostService
    {
        private readonly int _userId;
        private readonly AppDbContext _dbContext;
        public PostService (AppDbContext dbContext) {
            _dbContext = dbContext;
        }
        // * POST Create a post - required
        public async Task<bool> CreatePostAsync(PostCreate request) 
        {
            var postEntity = new PostEntity
            {
                Title = request.Title,
                Text = request.Text,
                AuthorId = _userId
            };

            _dbContext.Posts.Add(postEntity);

            var numberOfChanges = await _dbContext.SaveChangesAsync();

            return numberOfChanges == 1;
        }

        // * GET All posts - required
        public async Task<IEnumerable<PostListItem>> GetAllPostsAsync() 
        {
            var posts = await _dbContext.Posts
            .Where(entity => entity.AuthorId == _userId)
            .Select(entity => new PostListItem
            {
                Id = entity.Id,
                Title = entity.Title,
                AuthorId = entity.AuthorId
            })

            .ToListAsync();

            return posts;
        }

        // * GET Posts by author id
        // public Task<PostDetail> GetPostsByAuthorIdAsync(int authorId) {

        // }

        // * PUT Update a post
        // public async Task<bool> UpdatePostAsync(PostUpdate request) {

        // }

        // * DELETE Delete a Post
        // public async Task<bool> DeletePostAsync(int noteId) {
            
        // }
    }
}