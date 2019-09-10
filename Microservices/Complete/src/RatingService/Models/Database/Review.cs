using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RatingService.Models.Database
{
    public class Review
    {
        public int ReviewId { get; set; }
        public Rating Rating { get; set; }
        public string ReviewContent { get; set; }
        public bool Flagged { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}
