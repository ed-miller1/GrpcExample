using System;

namespace PaymentService.Models.Database
{
    public class PurchasePayment
    {
        public int PurchasePaymentId { get; set; }
        public string PurchaserName { get; set; }
        public string BankNumber { get; set; }
        public long Amount { get; set; }
        public Purchase Purchase { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}
