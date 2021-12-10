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

        public async Task AddWarehouseAsync(Warehouse warehouse)
        {
            await _unitOfWork.Warehouses.AddAsync(warehouse);
        }

        public async Task<Warehouse> GetWarehouseByIDAsync(int id)
        {
            var warehouse = await _unitOfWork.Warehouses.GetByIDAsync(id);
            return warehouse;
        }

        public async Task<IEnumerable<Warehouse>> GetWarehousesAsync()
        {
            var warehouses = await _unitOfWork.Warehouses.GetAllAsync();
            return warehouses;
        }

        public async Task RemoveWarehouse(int id)
        {
            _unitOfWork.Warehouses.Remove(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveWarehouse(Warehouse warehouse)
        {
            _unitOfWork.Warehouses.Remove(warehouse);
            await _unitOfWork.CommitAsync();
        }

        public Warehouse UpdateWarehouse(Warehouse warehouseToUpdate, Warehouse warehouse)
        {
            throw new NotImplementedException();
        }
    }
}
