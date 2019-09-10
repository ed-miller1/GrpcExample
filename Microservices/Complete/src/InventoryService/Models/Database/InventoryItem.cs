using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.Models.Database
{
    public class InventoryItem
    {
        public int InventoryItemId { get; set; }
        public string InventoryItemName { get; set; }
        public ICollection<InventoryCategory> Categories { get; set; }

    }
}
