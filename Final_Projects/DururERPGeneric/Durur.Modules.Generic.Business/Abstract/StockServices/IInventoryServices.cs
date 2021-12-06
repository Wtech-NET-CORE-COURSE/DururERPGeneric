using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface IInventoryServices
    {
        Task<IEnumerable<Inventory>> GetInventoriesAsync();

        Task<IEnumerable<Inventory>> GetInventoryByWarehouseID(int warehouseID);

        Task<IEnumerable<Inventory>> GetInventoryByProductID(int productID);

        void AddInventory(Inventory inventory);

        Inventory UpdateInventory(Inventory inventory);

        void DeleteInventory(Inventory inventory);
    }
}
