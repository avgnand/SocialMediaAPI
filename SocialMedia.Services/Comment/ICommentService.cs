namespace SocialMedia.Services.Comment
{
    public interface ICommentService
    {
        Task<bool> CreateCommentAsync(CommentCreate request);
        Task<CommentDetail> GetCommentByPostIdAsync(int postId);
        // Task<CommentDetail> GetCommentByAuthorIdAsync(int authorId);
        // Task<bool> UpdateCommentAsync(CommentUpdate request);
        // Task<bool> DeleteCommentAsync(int commentId);
    }
}