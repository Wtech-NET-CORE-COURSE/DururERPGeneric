using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface IOrderStatusServices
    {
        Task<IEnumerable<OrderStatus>> GetOrderStatusesAsync();

        OrderStatus GetOrderStatusByID(int id);

        void AddOrderStatus(OrderStatus orderStatus);

        OrderStatus UpdateOrderStatus(OrderStatus orderStatus);

        void DeleteOrderStatus(int id);
    }
}
