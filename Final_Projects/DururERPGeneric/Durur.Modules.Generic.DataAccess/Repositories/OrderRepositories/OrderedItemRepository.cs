using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.DataAccess.Repositories
{
    public class OrderedItemRepository : Repository<OrderedItem>,IOrderedItemRepository
    {
        public OrderedItemRepository(ErpGenericDbContext context) : base(context)
        {
        }

        public Task<IEnumerable<OrderedItem>> GetOrderedItemsByOrderIDAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
