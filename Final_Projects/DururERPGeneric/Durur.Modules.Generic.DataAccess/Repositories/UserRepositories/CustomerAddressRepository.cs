using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.DataAccess.Repositories
{
    public class CustomerAddressRepository : Repository<CustomerAddress>, ICustomerAddressRepository
    {
        public CustomerAddressRepository(ErpGenericDbContext context) : base(context)
        {
        }

        public Task<IEnumerable<CustomerAddress>> GetCustomerAddressesByCustomerID(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
