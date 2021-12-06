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

        Task<IEnumerable<Order>> GetOrdersByCustomerID(int customerId);

        Order GetOrderById(int id);

        void AddOrder(Order order);

        Order UpdateOrder(Order order);

        void DeleteOrder(int id);

    }
}
