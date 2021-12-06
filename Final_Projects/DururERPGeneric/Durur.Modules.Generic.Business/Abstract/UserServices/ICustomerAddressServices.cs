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

        CustomerAddress GetCustomerAddressByID(int id);

        Task<IEnumerable<CustomerAddress>> GetCustomerAddressesByCustomerID(int customerId);

        void AddCustomerAddress(CustomerAddress customerAddress);

        CustomerAddress UpdateCustomerAddress(CustomerAddress customerAddress);

        void DeleteCustomerAddress(int id);
    }
}
