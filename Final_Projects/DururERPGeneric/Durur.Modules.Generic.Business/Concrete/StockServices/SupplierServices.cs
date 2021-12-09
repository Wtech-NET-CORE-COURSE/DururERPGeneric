using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class SupplierServices : ISupplierServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public SupplierServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

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

        public Task RemoveSupplier(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public Supplier UpdateSupplier(Supplier supplierToUpdate, Supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}
