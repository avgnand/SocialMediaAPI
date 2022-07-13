using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models.Reply
{
    public class ReplyCreate
    {
        [Required]
        [MaxLength(100, ErrorMessage = "{0} must be no more than {1} characters long.")]
        public string Text { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
    }
}