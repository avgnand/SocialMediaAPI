using SocialMedia.Data;
using SocialMedia.Models;
using SocialMedia.Models.Comment;
using SocialMedia.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace SocialMedia.Services.Comment
{
    public class CommentService : ICommentService
    {
        private readonly Guid _userId;
        private readonly AppDbContext _dbContext;
        public CommentService (AppDbContext dbContext) {
            _dbContext = dbContext;
        }
        // * POST Create a comment - required
        public async Task<bool> CreateCommentAsync(CommentCreate request) 
        {
            var commentEntity = new CommentEntity
            {
                Text = request.Text,
                AuthorId = _userId
            };

            _dbContext.Comments.Add(commentEntity);

            var numberOfChanges = await _dbContext.SaveChangesAsync();

            return numberOfChanges == 1;
        }

        // * GET Comment by post id - required
        public async Task<CommentDetail> GetCommentByPostIdAsync(int postId) 
        {
            var commentEntity = await _dbContext.Comments
            .FirstOrDefaultAsync(e => e.Id == postId && e.AuthorId == _userId);

            return commentEntity is null ? null : new CommentDetail
            {
                Id = commentEntity.Id,
                Text = commentEntity.Text,
                AuthorId = commentEntity.AuthorId
            };
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