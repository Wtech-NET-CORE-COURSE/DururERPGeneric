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
    /// Customer orders controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderServices _orderServices;

        /// <summary>
        /// Order controller constructor
        /// </summary>
        public OrderController()
        {
            _orderServices = new OrderServices();
        }

        /// <summary>
        /// Get all orders from table
        /// </summary>
        /// <returns>All orders</returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var orders = await _orderServices.GetOrdersAsync();
            return Ok(orders);
        }
        /// <summary>
        /// Get order by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Order</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Order order = _orderServices.GetOrderById(id);
            if (order != null)
                return Ok(order);
            return NotFound();
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetByCustomerID(int id)
        {
            var orders = await _orderServices.GetOrdersByCustomerID(id);
            return Ok(orders);
        }


        /// <summary>
        /// Create Order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddOrder([FromBody] Order order)
        {
            _orderServices.AddOrder(order);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            if (_orderServices.GetOrderById(id) != null)
            {
                _orderServices.DeleteOrder(id);
                return Ok();
            }
            return NotFound();
        }

        [HttpPut]
        public IActionResult UpdateOrder([FromBody]Order order)
        {
            return Ok(_orderServices.UpdateOrder(order));
        }

    }
}
