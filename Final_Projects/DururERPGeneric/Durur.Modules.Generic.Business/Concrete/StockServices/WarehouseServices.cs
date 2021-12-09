using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class WarehouseServices : IWarehouseServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public WarehouseServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task AddWarehouseAsync(Warehouse warehouse)
        {
            throw new NotImplementedException();
        }

        public Task<Warehouse> GetWarehouseByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Warehouse>> GetWarehousesAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveWarehouse(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveWarehouse(Warehouse warehouse)
        {
            throw new NotImplementedException();
        }

        public Warehouse UpdateWarehouse(Warehouse warehouseToUpdate, Warehouse warehouse)
        {
            throw new NotImplementedException();
        }
    }
}
