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

        public Task AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer UpdateCustomer(Customer customerToUpdate, Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
