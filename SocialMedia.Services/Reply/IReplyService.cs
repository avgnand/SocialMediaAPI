namespace SocialMedia.Services.Reply
{
    public interface IReplyService
    {
        Task<bool> CreateReplyAsync(ReplyCreate request);
        Task<ReplyDetail> GetReplyByCommentIdAsync(int commentId);
        // Task<ReplyDetail> GetReplyByAuthorIdAsync(int authorId);
        // Task<bool> UpdateReplyAsync(ReplyUpdate request);
        // Task<bool> DeleteReplyAsync(int replyId);
    }
}