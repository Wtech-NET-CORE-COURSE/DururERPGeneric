using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
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
        private readonly IOrderStatusServices _orderStatusServices;

        public OrderStatusController(IOrderStatusServices orderStatusServices)
        {
            _orderStatusServices = orderStatusServices;
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
            var status = _orderStatusServices.GetOrderStatusByIDAsync(id);
            return Ok(status);
        }

        [HttpPost]
        public IActionResult AddOrderStatus([FromBody]OrderStatus orderStatus)
        {
            _orderStatusServices.AddOrderStatusAsync(orderStatus);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateOrderStatus([FromBody]OrderStatus orderStatus)
        {
            _orderStatusServices.UpdateOrderStatus(orderStatus,orderStatus);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrderStatus(int id)
        {
            if (_orderStatusServices.GetOrderStatusByIDAsync(id) != null)
            {
                _orderStatusServices.RemoveOrderStatus(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
