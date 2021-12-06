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

        Supplier GetSupplierByID(int id);

        void AddSupplier(Supplier supplier);

        Supplier UpdateSupplier(Supplier supplier);

        void DeleteSupplier(int id);
    }
}
