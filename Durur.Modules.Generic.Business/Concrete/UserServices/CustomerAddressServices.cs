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

        public async Task AddCustomerAddressAsync(CustomerAddress customerAddress)
        {
            await _unitOfWork.CustomerAddresses.AddAsync(customerAddress);
        }

        public async Task AddCustomerAddressRangeAsync(IEnumerable<CustomerAddress> customerAddress)
        {
            await _unitOfWork.CustomerAddresses.AddRangeAsync(customerAddress);
        }

        public async Task<IEnumerable<CustomerAddress>> GetCustomerAddressAsync()
        {
            var customerAddresses= await _unitOfWork.CustomerAddresses.GetAllAsync();
            return customerAddresses;
        }

        public async Task<CustomerAddress> GetCustomerAddressByIDAsync(int id)
        {
            var customerAddress = await _unitOfWork.CustomerAddresses.GetByIDAsync(id);
            return customerAddress;
        }

        public async Task<IEnumerable<CustomerAddress>> GetCustomerAddressesByCustomerIDAsync(int customerId)
        {
            var customerAddresses = await _unitOfWork.CustomerAddresses.GetCustomerAddressesByCustomerID(customerId);
            return customerAddresses;
        }

        public async Task RemoveCustomerAddress(int id)
        {
            _unitOfWork.CustomerAddresses.Remove(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveCustomerAddress(CustomerAddress customerAddress)
        {
            _unitOfWork.CustomerAddresses.Remove(customerAddress);
            await _unitOfWork.CommitAsync();
        }

        public CustomerAddress UpdateCustomerAddress(CustomerAddress customerAddressToUpdate, CustomerAddress customerAddress)
        {
            throw new NotImplementedException();
        }
    }
}
