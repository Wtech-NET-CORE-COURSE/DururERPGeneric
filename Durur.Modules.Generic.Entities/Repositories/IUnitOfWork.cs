using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Entities.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IJobRepository Jobs { get; }
        ICompanyPositionRepository CompanyPositions { get; }
        IDepartmentRepository Departments { get; }
        IEmployeeRepository Employees { get; }
        IEmployeeCompanyPositionRepository EmployeeCompanyPositions { get; }


        IOrderStatusRepository OrderStatuses { get; }
        IOrderRepository Orders { get; }
        IOrderedItemRepository OrderedItems { get; }


        ISupplierRepository Suppliers { get; }
        IProductRepository Products { get; }
        IWarehouseRepository Warehouses { get; }
        IInventoryRepository Inventories { get; }


        IUserRepository Users { get; }
        ICustomerAddressRepository CustomerAddresses { get; }
        ICustomerRepository Customers { get; }


        ICountryRepository Countries { get; }
        ILocationRepository Locations { get; }


        Task<int> CommitAsync();
    }
}
