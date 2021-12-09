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

        public Task AddOrderAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetOrdersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetOrdersByCustomerIDAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Order UpdateOrder(Order orderToUpdate, Order order)
        {
            throw new NotImplementedException();
        }
    }
}
