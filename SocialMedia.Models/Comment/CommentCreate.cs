using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SocialMedia.Models.Comment
{
    public class CommentCreate
    {
        [Required]
        [MaxLength(100, ErrorMessage = "{0} must be no more than {1} characters long.")]
        public string Text { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
    }
}