using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface IOrderedItemServices
    {
        Task<IEnumerable<OrderedItem>> GetOrderedItemsAsync();

        Task<IEnumerable<OrderedItem>> GetOrderedItemsByOrderIDAsync(int id);

        Task<OrderedItem> GetOrderedItemByIDAsync(int id);

        Task AddOrderedItemAsync(OrderedItem orderedItem);

        Task AddOrderedItemRangeAsync(IEnumerable<OrderedItem> orderedItems);

        OrderedItem UpdateOrderedItem(OrderedItem orderedItemToUpdate,OrderedItem orderedItem);

        Task RemoveOrderedItem(int id);
        Task RemoveOrderedItem(OrderedItem orderedItem);
        Task RemoveOrderedItemRange(IEnumerable<OrderedItem> orderedItems);
    }
}
