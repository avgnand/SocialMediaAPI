using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SocialMedia.Data.Entities
{
    public class ReplyEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public CommentEntity Comment { get; set; }
        [ForeignKey(nameof(Comment))]
        public int CommentId { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
        
    }
}