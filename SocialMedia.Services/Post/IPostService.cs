namespace SocialMedia.Services.Post
{
    public interface IPostService
    {
        Task<bool> CreatePostAsync();
        Task<> GetAllPostsAsync();
        // Task<> GetPostByAuthorIdAsync();
        // Task<bool> UpdatePostAsync();
        // Task<bool> DeletePostAsync();
    }
}