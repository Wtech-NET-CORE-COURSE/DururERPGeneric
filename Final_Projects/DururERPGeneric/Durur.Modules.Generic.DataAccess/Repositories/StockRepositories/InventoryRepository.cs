using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.DataAccess.Repositories
{
    public class InventoryRepository : Repository<Inventory>,IInventoryRepository
    {
        public InventoryRepository(ErpGenericDbContext context) : base(context)
        {
        }

        public Task<IEnumerable<Inventory>> GetInventoryByProductID(int productID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Inventory>> GetInventoryByWarehouseID(int warehouseID)
        {
            throw new NotImplementedException();
        }
    }
}
