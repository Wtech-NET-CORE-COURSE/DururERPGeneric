using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class InventoryServices : IInventoryServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public InventoryServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddInventoryAsync(Inventory inventory)
        {
            await _unitOfWork.Inventories.AddAsync(inventory);
        }

        public async Task<IEnumerable<Inventory>> GetInventoriesAsync()
        {
            var inventories = await _unitOfWork.Inventories.GetAllAsync();
            return inventories;
        }

        public async Task<IEnumerable<Inventory>> GetInventoryByProductIDAsync(int productID)
        {
            var inventories = await _unitOfWork.Inventories.GetInventoryByProductID(productID);
            return inventories;
        }

        public async Task<IEnumerable<Inventory>> GetInventoryByWarehouseIDAsync(int warehouseID)
        {
            var inventories = await _unitOfWork.Inventories.GetInventoryByWarehouseID(warehouseID);
            return inventories;
        }

        public async Task RemoveInventory(Inventory inventory)
        {
            _unitOfWork.Inventories.Remove(inventory);
            await _unitOfWork.CommitAsync();
        }

        public Inventory UpdateInventory(Inventory inventoryToUpdate, Inventory inventory)
        {
            throw new NotImplementedException();
        }
    }
}
