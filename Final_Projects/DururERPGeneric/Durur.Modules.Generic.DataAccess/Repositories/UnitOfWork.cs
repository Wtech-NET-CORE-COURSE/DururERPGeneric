using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ErpGenericDbContext _context;

        public UnitOfWork(ErpGenericDbContext context)
        {
            this._context = context;
            
        }

        public IJobRepository Jobs => throw new NotImplementedException();

        public ICompanyPositionRepository CompanyPositions => throw new NotImplementedException();

        public IDepartmentRepository Departments => throw new NotImplementedException();

        public IEmployeeRepository Employees => throw new NotImplementedException();

        public IEmployeeCompanyPositionRepository EmployeeCompanyPositions => throw new NotImplementedException();

        public IOrderStatusRepository OrderStatuses => throw new NotImplementedException();

        public IOrderRepository Orders => throw new NotImplementedException();

        public IOrderedItemRepository OrderedItems => throw new NotImplementedException();

        public ISupplierRepository Suppliers => throw new NotImplementedException();

        public IProductRepository Products => throw new NotImplementedException();

        public IWarehouseRepository Warehouses => throw new NotImplementedException();

        public IInventoryRepository Inventories => throw new NotImplementedException();

        public IUserRepository Users => throw new NotImplementedException();

        public ICustomerAddressRepository CustomerAddresses => throw new NotImplementedException();

        public ICustomerRepository Customers => throw new NotImplementedException();

        public ICountryRepository Countries => throw new NotImplementedException();

        public ILocationRepository Locations => throw new NotImplementedException();

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
