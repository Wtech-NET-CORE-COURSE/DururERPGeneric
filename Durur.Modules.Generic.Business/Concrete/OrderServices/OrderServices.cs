using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class OrderServices : IOrderServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddOrderAsync(Order order)
        {
            await _unitOfWork.Orders.AddAsync(order);
        }

        public async Task<Order> GetOrderByIDAsync(int id)
        {
            var order = await _unitOfWork.Orders.GetByIDAsync(id);
            return order;
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync()
        {
            var orders = await _unitOfWork.Orders.GetAllAsync();
            return orders;
        }

        public async Task<IEnumerable<Order>> GetOrdersByCustomerIDAsync(int customerId)
        {
            var order = await _unitOfWork.Orders.GetOrdersByCustomerID(customerId);
            return order;
        }

        public async Task RemoveOrder(int id)
        {
            _unitOfWork.Orders.Remove(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveOrder(Order order)
        {
            _unitOfWork.Orders.Remove(order);
            await _unitOfWork.CommitAsync();
        }

        public Order UpdateOrder(Order orderToUpdate, Order order)
        {
            throw new NotImplementedException();
        }
    }
}
