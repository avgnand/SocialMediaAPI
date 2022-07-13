using SocialMedia.Data;
using SocialMedia.Models.Reply;
using SocialMedia.Models;
using SocialMedia.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace SocialMedia.Services.Reply
{
    public class ReplyService : IReplyService
    {
        private readonly Guid _userId;
        private readonly AppDbContext _dbContext;
        public ReplyService(AppDbContext dbContext) {
            _dbContext = dbContext;
        }
        // * POST Reply to a comment using Foreign Key - required
        public async Task<bool> CreateReplyAsync(ReplyCreate request) 
        {
            var replyEntity = new ReplyEntity
            {
                Text = request.Text,
                AuthorId = _userId
            };

            _dbContext.Replys.Add(replyEntity);

            var numberOfChanges = await _dbContext.SaveChangesAsync();

            return numberOfChanges == 1;
        }

        // * GET Reply by comment id - required
        public async Task<ReplyDetail> GetReplyByCommentIdAsync(int commentId) 
        {
            var replyEntity = await _dbContext.Replys
            .FirstOrDefaultAsync(e => e.Id == commentId && e.AuthorId == _userId);

            return replyEntity is null ? null : new ReplyDetail
            {
                Id = replyEntity.Id,
                Text = replyEntity.Text,
                AuthorId = replyEntity.AuthorId
            };
        }

        // * GET Reply by author id
        // Task<ReplyDetail> GetReplyByAuthorIdAsync(int authorId) {

        // }

        // * PUT Update a reply
        // Task<bool> UpdateReplyAsync(ReplyUpdate request) {

        // }

        // * DELETE Delete a reply
        // Task<bool> DeleteReplyAsync(int replyId) {

        // }
    }
}