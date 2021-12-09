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

        public Task AddInventoryAsync(Inventory inventory)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Inventory>> GetInventoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Inventory>> GetInventoryByProductIDAsync(int productID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Inventory>> GetInventoryByWarehouseIDAsync(int warehouseID)
        {
            throw new NotImplementedException();
        }

        public Task RemoveInventory(Inventory inventory)
        {
            throw new NotImplementedException();
        }

        public Inventory UpdateInventory(Inventory inventoryToUpdate, Inventory inventory)
        {
            throw new NotImplementedException();
        }
    }
}
