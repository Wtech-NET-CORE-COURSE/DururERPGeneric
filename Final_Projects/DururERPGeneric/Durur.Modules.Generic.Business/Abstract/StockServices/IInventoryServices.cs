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

        Task<IEnumerable<Inventory>> GetInventoryByWarehouseIDAsync(int warehouseID);

        Task<IEnumerable<Inventory>> GetInventoryByProductIDAsync(int productID);

        Task AddInventoryAsync(Inventory inventory);

        Inventory UpdateInventory(Inventory inventoryToUpdate,Inventory inventory);

        void RemoveInventory(Inventory inventory);
    }
}
