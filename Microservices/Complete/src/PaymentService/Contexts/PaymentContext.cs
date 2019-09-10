using Microsoft.EntityFrameworkCore;
using PaymentService.Models.Database;

namespace PaymentService.Contexts
{
    public class PaymentContext : DbContext
    {
        public PaymentContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<InventoryPurchase> InventoryPurchases { get; set; }
        public DbSet<PurchasePayment> PurchasePayments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
    }
}
