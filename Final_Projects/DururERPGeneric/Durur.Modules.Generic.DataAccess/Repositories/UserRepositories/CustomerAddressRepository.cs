using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.DataAccess.Repositories
{
    public class CustomerAddressRepository : Repository<CustomerAddress>, ICustomerAddressRepository
    {
        public CustomerAddressRepository(ErpGenericDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<CustomerAddress>> GetCustomerAddressesByCustomerID(int customerId)
        {
            var customerAddress = await Context.Customer_Addresses.Where(c => c.Customer.Customer_ID == customerId).ToListAsync();
            return customerAddress;
        }
    }
}
