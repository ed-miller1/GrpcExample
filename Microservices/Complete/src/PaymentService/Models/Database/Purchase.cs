using System;

namespace PaymentService.Models.Database
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}
