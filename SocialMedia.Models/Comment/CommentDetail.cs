using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models.Comment
{
    public class CommentDetail
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Guid AuthorId { get; set; }
    }
}