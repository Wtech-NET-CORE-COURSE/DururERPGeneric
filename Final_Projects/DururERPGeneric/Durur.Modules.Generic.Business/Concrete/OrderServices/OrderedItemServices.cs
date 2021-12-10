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

        public async Task AddOrderedItemAsync(OrderedItem orderedItem)
        {
            await _unitOfWork.OrderedItems.AddAsync(orderedItem);
        }

        public async Task AddOrderedItemRangeAsync(IEnumerable<OrderedItem> orderedItems)
        {
            await _unitOfWork.OrderedItems.AddRangeAsync(orderedItems);
        }

        public async Task<OrderedItem> GetOrderedItemByIDAsync(int id)
        {
            var orderedItem = await _unitOfWork.OrderedItems.GetByIDAsync(id);
            return orderedItem;
        }

        public async Task<IEnumerable<OrderedItem>> GetOrderedItemsAsync()
        {
            var orderedItems = await _unitOfWork.OrderedItems.GetAllAsync();
            return orderedItems;
        }

        public async Task<IEnumerable<OrderedItem>> GetOrderedItemsByOrderIDAsync(int id)
        {
            var orderedItems = await _unitOfWork.OrderedItems.GetOrderedItemsByOrderIDAsync(id);
            return orderedItems;
        }

        public Task RemoveOrderedItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveOrderedItem(OrderedItem orderedItem)
        {
            throw new NotImplementedException();
        }

        public Task RemoveOrderedItemRange(IEnumerable<OrderedItem> orderedItems)
        {
            throw new NotImplementedException();
        }

        public OrderedItem UpdateOrderedItem(OrderedItem orderedItemToUpdate, OrderedItem orderedItem)
        {
            throw new NotImplementedException();
        }
    }
}
