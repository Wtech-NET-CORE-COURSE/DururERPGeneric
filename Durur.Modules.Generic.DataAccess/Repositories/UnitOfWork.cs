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
        private JobRepository _jobRepository;
        private CompanyPositionRepository _companyPositionRepository;
        private DepartmentRepository _departmentRepository;
        private EmployeeRepository _employeeRepository;
        private EmployeeCompanyPositionRepository _employeeCompanyPositionRepository;
        private OrderStatusRepository _orderStatusRepository;
        private OrderRepository _orderRepository;
        private OrderedItemRepository _orderedItemRepository;
        private SupplierRepository _supplierRepository;
        private ProductRepository _productRepository;
        private WarehouseRepository _warehouseRepository;
        private InventoryRepository _inventoryRepository;
        private UserRepository _userRepository;
        private CustomerAddressRepository _customerAddressRepository;
        private CustomerRepository _customerRepository;
        private CountryRepository _countryRepository;
        private LocationRepository _locationRepository;



        public UnitOfWork(ErpGenericDbContext context)
        {
            this._context = context;
        }

        public IJobRepository Jobs => _jobRepository = _jobRepository ?? new JobRepository(_context);

        public ICompanyPositionRepository CompanyPositions => _companyPositionRepository = _companyPositionRepository ?? new CompanyPositionRepository(_context);

        public IDepartmentRepository Departments => _departmentRepository = _departmentRepository ?? new DepartmentRepository(_context);

        public IEmployeeRepository Employees => _employeeRepository = _employeeRepository ?? new EmployeeRepository(_context);

        public IEmployeeCompanyPositionRepository EmployeeCompanyPositions => _employeeCompanyPositionRepository = _employeeCompanyPositionRepository ?? new EmployeeCompanyPositionRepository(_context);

        public IOrderStatusRepository OrderStatuses => _orderStatusRepository = _orderStatusRepository ?? new OrderStatusRepository(_context);

        public IOrderRepository Orders => _orderRepository = _orderRepository ?? new OrderRepository(_context);

        public IOrderedItemRepository OrderedItems => _orderedItemRepository = _orderedItemRepository ?? new OrderedItemRepository(_context);

        public ISupplierRepository Suppliers => _supplierRepository = _supplierRepository ?? new SupplierRepository(_context);

        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_context);

        public IWarehouseRepository Warehouses => _warehouseRepository = _warehouseRepository ?? new WarehouseRepository(_context);

        public IInventoryRepository Inventories => _inventoryRepository = _inventoryRepository ?? new InventoryRepository(_context);

        public IUserRepository Users => _userRepository = _userRepository ?? new UserRepository(_context);

        public ICustomerAddressRepository CustomerAddresses => _customerAddressRepository = _customerAddressRepository ?? new CustomerAddressRepository(_context);

        public ICustomerRepository Customers => _customerRepository = _customerRepository ?? new CustomerRepository(_context);

        public ICountryRepository Countries => _countryRepository = _countryRepository ?? new CountryRepository(_context);

        public ILocationRepository Locations => _locationRepository = _locationRepository ?? new LocationRepository(_context);

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
