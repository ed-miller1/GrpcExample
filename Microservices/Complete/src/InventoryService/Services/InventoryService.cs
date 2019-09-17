using System.Threading.Tasks;
using Grpc.Core;
using InventoryService.Contexts;
using Microsoft.Extensions.Logging;

namespace InventoryService.Services
{
    public class InventoryService : InventoryServices.InventoryServices.InventoryServicesBase
    {
        private readonly ILogger<InventoryContext> logger;
        private readonly InventoryContext inventoryContext;
        public InventoryService(ILogger<InventoryContext> logger,InventoryContext inventoryContext)
        {
            this.logger = logger;
            this.inventoryContext = inventoryContext;
        }

        public override Task<InventoryItem> GetInventoryItemById(InventoryIdRequest request, ServerCallContext context)
        {
            return null;
        }

        public override Task<InventoryItem> GetInventoryItemByName(InventoryNameRequest request, ServerCallContext context)
        {
            return null;
        }

        public override Task<InventoryByCategoryReply> GetInventoryItemsByCategoryId(InventoryCategoryIdRequest request, ServerCallContext context)
        {
            return null;
        }

        public override Task<InventoryByCategoryReply> GetInventoryItemsByCategoryName(InventoryCategoryNameRequest request, ServerCallContext context)
        {
            return null;
        }

        public override Task<InventoryCategoriesReply> GetInventoryCategories(GetInventoryCategoriesRequest request, ServerCallContext context)
        {
            return null;
        }

        public override Task<InventoryItem> CreateInventoryItem(NewInventoryItem request, ServerCallContext context)
        {
            return null;
        }

        public override Task<InventoryItem> UpdateInventoryItem(InventoryItem request, ServerCallContext context)
        {
            return null;
        }

        public override Task<InventoryDeleteReply> DeleteInventoryItem(InventoryItem request, ServerCallContext context)
        {
            return null;
        }

        public override Task<InventoryCategory> CreateInventoryCategory(NewInventoryCategory request, ServerCallContext context)
        {
            return null;
        }

        public override Task<InventoryCategory> UpdateInventoryCategory(InventoryCategory request, ServerCallContext context)
        {
            return null;
        }

        public override Task<InventoryDeleteReply> DeleteInventoryCategory(InventoryCategory request, ServerCallContext context)
        {
            return null;
        }
    }
}
