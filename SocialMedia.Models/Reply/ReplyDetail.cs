using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models.Reply
{
    public class ReplyDetail
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Guid AuthorId { get; set; }

    }
}