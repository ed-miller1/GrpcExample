using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace InventoryService.Contexts
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> contextOptions) : base(contextOptions) { }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<InventoryCategory> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
    }
}
