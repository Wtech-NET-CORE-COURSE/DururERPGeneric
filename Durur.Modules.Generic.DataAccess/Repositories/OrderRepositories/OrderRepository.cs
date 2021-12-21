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
    public class OrderRepository : Repository<Order>,IOrderRepository
    {
        public OrderRepository(ErpGenericDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Order>> GetOrdersByCustomerID(int customerId)
        {
            var orders = await Context.Orders.Where(o => o.Customer.Customer_ID==customerId).ToListAsync();
            return orders;
        }
    }
}
