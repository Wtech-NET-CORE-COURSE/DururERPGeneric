using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class SupplierServices : ISupplierServices
    {
        public Task AddSupplierAsync(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public Task<Supplier> GetSupplierByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Supplier>> GetSuppliersAsync()
        {
            throw new NotImplementedException();
        }

        public void RemoveSupplier(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public Supplier UpdateSupplier(Supplier supplierToUpdate, Supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}
