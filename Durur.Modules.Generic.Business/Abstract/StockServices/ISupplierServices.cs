using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface ISupplierServices
    {
        Task<IEnumerable<Supplier>> GetSuppliersAsync();

        Task<Supplier> GetSupplierByIDAsync(int id);

        Task AddSupplierAsync(Supplier supplier);

        Supplier UpdateSupplier(Supplier supplierToUpdate, Supplier supplier);

        Task RemoveSupplier(int id);
        Task RemoveSupplier(Supplier supplier);
    }
}
