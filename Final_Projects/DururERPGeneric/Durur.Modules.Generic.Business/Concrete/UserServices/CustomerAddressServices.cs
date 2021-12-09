using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class CustomerAddressServices : ICustomerAddressServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerAddressServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task AddCustomerAddressAsync(CustomerAddress customerAddress)
        {
            throw new NotImplementedException();
        }

        public Task AddCustomerAddressRangeAsync(IEnumerable<CustomerAddress> customerAddress)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CustomerAddress>> GetCustomerAddressAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CustomerAddress> GetCustomerAddressByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CustomerAddress>> GetCustomerAddressesByCustomerIDAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveCustomerAddress(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveCustomerAddress(CustomerAddress customerAddress)
        {
            throw new NotImplementedException();
        }

        public CustomerAddress UpdateCustomerAddress(CustomerAddress customerAddressToUpdate, CustomerAddress customerAddress)
        {
            throw new NotImplementedException();
        }
    }
}
