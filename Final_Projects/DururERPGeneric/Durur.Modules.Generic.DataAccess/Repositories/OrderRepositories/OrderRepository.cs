using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.DataAccess.Repositories
{
    public class OrderRepository : Repository<Order>,IOrderRepository
    {
        public OrderRepository(ErpGenericDbContext context) : base(context)
        {
        }

        public Task<IEnumerable<Order>> GetOrdersByCustomerID(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
