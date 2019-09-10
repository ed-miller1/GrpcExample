using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using InventoryService.Contexts;
using Microsoft.Extensions.Logging;
using static InventoryService.InventoryService;

namespace InventoryService.Services
{
    public class InventoryService : InventoryServiceBase
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
            return base.GetInventoryItemById(request, context);
        }

        public override Task<InventoryItem> GetInventoryItemByName(InventoryNameRequest request, ServerCallContext context)
        {
            return base.GetInventoryItemByName(request, context);
        }

        public override Task<InventoryByCategoryReply> GetInventoryItemsByCategoryId(InventoryCategoryIdRequest request, ServerCallContext context)
        {
            return base.GetInventoryItemsByCategoryId(request, context);
        }

        public override Task<InventoryByCategoryReply> GetInventoryItemsByCategoryName(InventoryCategoryNameRequest request, ServerCallContext context)
        {
            return base.GetInventoryItemsByCategoryName(request, context);
        }

        public override Task<InventoryCategoriesReply> GetInventoryCategories(GetInventoryCategoriesRequest request, ServerCallContext context)
        {
            return base.GetInventoryCategories(request, context);
        }

        public override Task<InventoryItem> CreateInventoryItem(NewInventoryItem request, ServerCallContext context)
        {
            return base.CreateInventoryItem(request, context);
        }

        public override Task<InventoryItem> UpdateInventoryItem(InventoryItem request, ServerCallContext context)
        {
            return base.UpdateInventoryItem(request, context);
        }

        public override Task<InventoryDeleteReply> DeleteInventoryItem(InventoryItem request, ServerCallContext context)
        {
            return base.DeleteInventoryItem(request, context);
        }

        public override Task<InventoryCategory> CreateInventoryCategory(NewInventoryCategory request, ServerCallContext context)
        {
            return base.CreateInventoryCategory(request, context);
        }

        public override Task<InventoryCategory> UpdateInventoryCategory(InventoryCategory request, ServerCallContext context)
        {
            return base.UpdateInventoryCategory(request, context);
        }

        public override Task<InventoryDeleteReply> DeleteInventoryCategory(InventoryCategory request, ServerCallContext context)
        {
            return base.DeleteInventoryCategory(request, context);
        }
    }
}
