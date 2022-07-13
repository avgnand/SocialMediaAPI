using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SocialMedia.Models.Post
{
    public class PostCreate
    {
        [Required]
        [MinLength(10, ErrorMessage = "{0} must be at least {1} characters long.")]
        [MaxLength(100, ErrorMessage = "{0} must be no more than {1} characters long.")]
        public string Title { get; set; }
        [Required]
        [MaxLength(800, ErrorMessage = "{0} must be no more than {1} characters long.")]
        public string Text { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
    }
}