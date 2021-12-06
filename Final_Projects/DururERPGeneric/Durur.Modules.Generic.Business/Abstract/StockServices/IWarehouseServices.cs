using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface IWarehouseServices
    {
        Task<IEnumerable<Warehouse>> GetWarehousesAsync();

        Task<Warehouse> GetWarehouseByIDAsync(int id);

        Task AddWarehouseAsync(Warehouse warehouse);

        Warehouse UpdateWarehouse(Warehouse warehouseToUpdate, Warehouse warehouse);

        void RemoveWarehouse(int id);
        void RemoveWarehouse(Warehouse warehouse);
    }
}
