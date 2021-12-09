using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface IOrderServices
    {
        Task<IEnumerable<Order>> GetOrdersAsync();

        Task<IEnumerable<Order>> GetOrdersByCustomerIDAsync(int customerId);

        Task<Order> GetOrderByIDAsync(int id);

        Task AddOrderAsync(Order order);

        Order UpdateOrder(Order orderToUpdate,Order order);

        Task RemoveOrder(int id);
        Task RemoveOrder(Order order);

    }
}
