using System;

namespace RatingService.Models.Database
{
    public class Rating
    {
        public int RatingId { get; set; }
        public Star StarRating { get; set; }
        public int UserId { get; set; }
        public int InventoryItemId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}
