using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface ICustomerServices
    {
        Task<IEnumerable<Customer>> GetCustomersAsync();

        Task<Customer> GetCustomerByIDAsync(int id);

        Task AddCustomer(Customer customer);

        Customer UpdateCustomer(Customer customerToUpdate,Customer customer);

        Task RemoveCustomer(int id);
        Task RemoveCustomer(Customer customer);
    }
}
