using System;

namespace PaymentService.Models.Database
{
    public class InventoryPurchase
    {
        public int InventoryPurchaseId { get; set; }
        public Purchase Purchase { get; set; }
        public int InventoryId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}
