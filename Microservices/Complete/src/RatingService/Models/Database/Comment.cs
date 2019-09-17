using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RatingService.Models.Database
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string commentContent { get; set; }
        public Review Review { get; set; }
        public int UserId { get; set; }
        public bool Flagged { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}
