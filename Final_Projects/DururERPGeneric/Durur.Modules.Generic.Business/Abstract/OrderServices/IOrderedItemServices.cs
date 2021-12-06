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

        OrderedItem GetOrderedItemByID(int id);

        void AddOrderedItem(OrderedItem orderedItem);

        void AddRangeOrderedItem(IEnumerable<OrderedItem> orderedItems);

        OrderedItem UpdateOrderedItem(OrderedItem orderedItem);

        void DeleteOrderedItem(int id);
    }
}
