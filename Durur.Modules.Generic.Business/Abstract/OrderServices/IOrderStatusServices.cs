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

        Task<OrderStatus> GetOrderStatusByIDAsync(int id);

        Task AddOrderStatusAsync(OrderStatus orderStatus);

        OrderStatus UpdateOrderStatus(OrderStatus orderStatusToUpdate,OrderStatus orderStatus);

        Task RemoveOrderStatus(int id);
        Task RemoveOrderStatus(OrderStatus orderStatus);
    }
}
