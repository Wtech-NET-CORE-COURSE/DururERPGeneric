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

        Warehouse GetWarehouseByID(int id);

        void AddWarehouse(Warehouse warehouse);

        Warehouse UpdateWarehouse(Warehouse warehouse);

        void DeleteWarehouse(int id);
    }
}
