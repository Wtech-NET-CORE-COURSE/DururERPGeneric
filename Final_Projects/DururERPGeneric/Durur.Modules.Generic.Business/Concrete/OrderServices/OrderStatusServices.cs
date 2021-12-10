using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class OrderStatusServices : IOrderStatusServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderStatusServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddOrderStatusAsync(OrderStatus orderStatus)
        {
            await _unitOfWork.OrderStatuses.AddAsync(orderStatus);
        }

        public async Task<OrderStatus> GetOrderStatusByIDAsync(int id)
        {
            var orderstatus = await _unitOfWork.OrderStatuses.GetByIDAsync(id);
            return orderstatus;
        }

        public async Task<IEnumerable<OrderStatus>> GetOrderStatusesAsync()
        {
            var orderstatus = await _unitOfWork.OrderStatuses.GetAllAsync();
            return orderstatus;
        }

        public async Task RemoveOrderStatus(int id)
        {
            _unitOfWork.OrderStatuses.Remove(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveOrderStatus(OrderStatus orderStatus)
        {
            _unitOfWork.OrderStatuses.Remove(orderStatus);
            await _unitOfWork.CommitAsync();
        }

        public OrderStatus UpdateOrderStatus(OrderStatus orderStatusToUpdate, OrderStatus orderStatus)
        {
            throw new NotImplementedException();
        }
    }
}
