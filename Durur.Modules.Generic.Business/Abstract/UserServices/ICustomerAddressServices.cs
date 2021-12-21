using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface ICustomerAddressServices
    {
        Task<IEnumerable<CustomerAddress>> GetCustomerAddressAsync();

        Task<CustomerAddress> GetCustomerAddressByIDAsync(int id);

        Task<IEnumerable<CustomerAddress>> GetCustomerAddressesByCustomerIDAsync(int customerId);

        Task AddCustomerAddressAsync(CustomerAddress customerAddress);
        Task AddCustomerAddressRangeAsync(IEnumerable<CustomerAddress> customerAddress);

        CustomerAddress UpdateCustomerAddress(CustomerAddress customerAddressToUpdate,CustomerAddress customerAddress);

        Task RemoveCustomerAddress(int id);
        Task RemoveCustomerAddress(CustomerAddress customerAddress);
    }
}
