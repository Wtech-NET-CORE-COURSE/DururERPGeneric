using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Entities.Repositories
{
    public interface IInventoryRepository : IRepository<Inventory>
    {
        Task<IEnumerable<Inventory>> GetInventoryByWarehouseID(int warehouseID);

        Task<IEnumerable<Inventory>> GetInventoryByProductID(int productID);
    }
}
