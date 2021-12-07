using Durur.Modules.Business.Abstract;
using Durur.Modules.Business.Concrete;
using Durur.Modules.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Durur.Modules.Api.Controllers
{
    /// <summary>
    /// Order status controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OrderStatusController : ControllerBase
    {
        private IOrderStatusServices _orderStatusServices;

        public OrderStatusController()
        {
            _orderStatusServices = new OrderStatusServices();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var statuses = await _orderStatusServices.GetOrderStatusesAsync();
            return Ok(statuses);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var status = _orderStatusServices.GetOrderStatusByID(id);
            return Ok(status);
        }

        [HttpPost]
        public IActionResult AddOrderStatus([FromBody]OrderStatus orderStatus)
        {
            _orderStatusServices.AddOrderStatus(orderStatus);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateOrderStatus([FromBody]OrderStatus orderStatus)
        {
            _orderStatusServices.UpdateOrderStatus(orderStatus);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrderStatus(int id)
        {
            if (_orderStatusServices.GetOrderStatusByID(id) != null)
            {
                _orderStatusServices.DeleteOrderStatus(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
