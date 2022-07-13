namespace SocialMedia.Services.Reply
{
    public interface IReplyService
    {
        Task<bool> CreateReplyAsync();
        Task<> GetReplyByCommentIdAsync();
        // Task<> GetReplyByAuthorIdAsync();
        // Task<bool> UpdateReplyAsync();
        // Task<bool> DeleteReplyAsync();
    }
}