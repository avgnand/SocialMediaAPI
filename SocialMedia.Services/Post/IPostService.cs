namespace SocialMedia.Services.Post
{
    public interface IPostService
    {
        Task<bool> CreatePostAsync(PostCreate request);
        Task<IEnumerable<PostListItem>> GetAllPostsAsync();
        // Task<PostDetail> GetPostByAuthorIdAsync(int authorId);
        // Task<bool> UpdatePostAsync(PostUpdate request);
        // Task<bool> DeletePostAsync(int noteId);
    }
}