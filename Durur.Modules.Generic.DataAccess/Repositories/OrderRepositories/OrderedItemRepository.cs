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
    public class OrderedItemRepository : Repository<OrderedItem>,IOrderedItemRepository
    {
        public OrderedItemRepository(ErpGenericDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<OrderedItem>> GetOrderedItemsByOrderIDAsync(int id)
        {
            var orderedItems = await Context.Ordered_Items.Where(o => o.Order.Order_ID==id).ToListAsync();
            return orderedItems;
        }
    }
}
