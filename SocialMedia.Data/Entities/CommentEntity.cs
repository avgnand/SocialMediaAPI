using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SocialMedia.Data.Entities
{
    public class CommentEntity
    {
        //id, text, guid(authid)
        [Key]
        public int Id { get; set; }
        [Required]
        public PostEntity Post { get; set; }
        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
        
    }
}