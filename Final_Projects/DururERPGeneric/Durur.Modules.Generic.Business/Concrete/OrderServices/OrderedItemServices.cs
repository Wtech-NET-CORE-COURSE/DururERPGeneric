using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class OrderedItemServices : IOrderedItemServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderedItemServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task AddOrderedItemAsync(OrderedItem orderedItem)
        {
            throw new NotImplementedException();
        }

        public Task AddOrderedItemRangeAsync(IEnumerable<OrderedItem> orderedItems)
        {
            throw new NotImplementedException();
        }

        public Task<OrderedItem> GetOrderedItemByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderedItem>> GetOrderedItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderedItem>> GetOrderedItemsByOrderIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveOrderedItem(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveOrderedItem(OrderedItem orderedItem)
        {
            throw new NotImplementedException();
        }

        public void RemoveOrderedItemRange(IEnumerable<OrderedItem> orderedItems)
        {
            throw new NotImplementedException();
        }

        public OrderedItem UpdateOrderedItem(OrderedItem orderedItemToUpdate, OrderedItem orderedItem)
        {
            throw new NotImplementedException();
        }
    }
}
