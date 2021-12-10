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

        public async Task AddSupplierAsync(Supplier supplier)
        {
            await _unitOfWork.Suppliers.AddAsync(supplier);
        }

        public async Task<Supplier> GetSupplierByIDAsync(int id)
        {
            var supplier = await _unitOfWork.Suppliers.GetByIDAsync(id);
            return supplier;
        }

        public async Task<IEnumerable<Supplier>> GetSuppliersAsync()
        {
            var suppliers = await _unitOfWork.Suppliers.GetAllAsync();
            return suppliers;
        }

        public async Task RemoveSupplier(int id)
        {
            _unitOfWork.Suppliers.Remove(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveSupplier(Supplier supplier)
        {
            _unitOfWork.Suppliers.Remove(supplier);
            await _unitOfWork.CommitAsync();
        }

        public Supplier UpdateSupplier(Supplier supplierToUpdate, Supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}
