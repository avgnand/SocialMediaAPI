namespace SocialMedia.Services.Comment
{
    public interface ICommentService
    {
        Task<bool> CreateCommentAsync();
        Task<> GetCommentByPostIdAsync();
        // Task<> GetCommentByAuthorIdAsync();
        // Task<bool> UpdateCommentAsync();
        // Task<bool> DeleteCommentAsync();
    }
}