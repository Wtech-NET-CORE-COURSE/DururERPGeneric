using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Entities.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IJobRepository Job { get; }
        ICompanyPositionRepository CompanyPosition { get; }
        IDepartmentRepository Department { get; }
        IEmployeeRepository Employee { get; }
        IEmployeeCompanyPositionRepository EmployeeCompanyPositionRepository { get; }


        IOrderStatusRepository OrderStatus { get; }
        IOrderRepository Order { get; }
        IOrderedItemRepository OrderedItem { get; }


        ISupplierRepository Supplier { get; }
        IProductRepository Product { get; }
        IWarehouseRepository Warehouse { get; }
        IInventoryRepository Inventory { get; }


        IUserRepository User { get; }
        ICustomerAddressRepository CustomerAddress { get; }
        ICustomerRepository Customer { get; }


        ICountryRepository Country { get; }
        ILocationRepository Location { get; }


        Task<int> CommitAsync();
    }
}
