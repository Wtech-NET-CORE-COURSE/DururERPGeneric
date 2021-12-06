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

        public IJobRepository Job => throw new NotImplementedException();

        public ICompanyPositionRepository CompanyPosition => throw new NotImplementedException();

        public IDepartmentRepository Department => throw new NotImplementedException();

        public IEmployeeRepository Employee => throw new NotImplementedException();

        public IEmployeeCompanyPositionRepository EmployeeCompanyPositionRepository => throw new NotImplementedException();

        public IOrderStatusRepository OrderStatus => throw new NotImplementedException();

        public IOrderRepository Order => throw new NotImplementedException();

        public IOrderedItemRepository OrderedItem => throw new NotImplementedException();

        public ISupplierRepository Supplier => throw new NotImplementedException();

        public IProductRepository Product => throw new NotImplementedException();

        public IWarehouseRepository Warehouse => throw new NotImplementedException();

        public IInventoryRepository Inventory => throw new NotImplementedException();

        public IUserRepository User => throw new NotImplementedException();

        public ICustomerAddressRepository CustomerAddress => throw new NotImplementedException();

        public ICustomerRepository Customer => throw new NotImplementedException();

        public ICountryRepository Country => throw new NotImplementedException();

        public ILocationRepository Location => throw new NotImplementedException();

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
