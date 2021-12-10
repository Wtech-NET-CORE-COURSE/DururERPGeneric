using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.DataAccess.Repositories
{
    public class InventoryRepository : Repository<Inventory>,IInventoryRepository
    {
        public InventoryRepository(ErpGenericDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Inventory>> GetInventoryByProductID(int productID)
        {
            var inventories = await Context.Inventories.Where(i => i.Product_ID == productID).ToListAsync();
            return inventories;
        }

        public async Task<IEnumerable<Inventory>> GetInventoryByWarehouseID(int warehouseID)
        {
            var inventories = await Context.Inventories.Where(i => i.Warehouse_ID == warehouseID).ToListAsync();
            return inventories;
        }
    }
}
