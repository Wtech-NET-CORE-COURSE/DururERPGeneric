using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class CustomerServices : ICustomerServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddCustomer(Customer customer)
        {
            await _unitOfWork.Customers.AddAsync(customer);

        }

        public async Task<Customer> GetCustomerByIDAsync(int id)
        {
            return await _unitOfWork.Customers.GetByIDAsync(id);
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            var customer = await _unitOfWork.Customers.GetAllAsync();
            return customer;
        }

        public async Task RemoveCustomer(int id)
        {
            _unitOfWork.Customers.Remove(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveCustomer(Customer customer)
        {
            _unitOfWork.Customers.Remove(customer);
            await _unitOfWork.CommitAsync();
        }

        public Customer UpdateCustomer(Customer customerToUpdate, Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
