using Microsoft.EntityFrameworkCore;
using SocialMedia.Data.Entities;

namespace SocialMedia.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }
        public DbSet<UserEntity> Users {get; set;}
        public DbSet<PostEntity> Posts {get; set;}
        public DbSet<CommentEntity> Comments {get; set;}
        public DbSet<ReplyEntity> Replys {get; set;}
    }
}