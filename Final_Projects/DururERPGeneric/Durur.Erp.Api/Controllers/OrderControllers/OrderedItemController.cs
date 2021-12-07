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
    /// Ordered item for orders controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OrderedItemController : ControllerBase
    {
        private IOrderedItemServices _orderedItemServices;

        public OrderedItemController()
        {
            _orderedItemServices = new OrderedItemServices();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var orderedItems = await _orderedItemServices.GetOrderedItemsAsync();
            return Ok(orderedItems);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetByOrderID(int id)
        {
            var orderedItems = await _orderedItemServices.GetOrderedItemsByOrderIDAsync(id);
            return Ok(orderedItems);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var orderedItem = _orderedItemServices.GetOrderedItemByID(id);
            return Ok(orderedItem);
        }

        [HttpPost]
        public IActionResult AddOrderedItem([FromBody]OrderedItem orderedItem)
        {
            _orderedItemServices.AddOrderedItem(orderedItem);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult AddRangeOrderedItem([FromBody]List<OrderedItem> orderedItems)
        {
            _orderedItemServices.AddRangeOrderedItem(orderedItems);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteOrderedItem(int id)
        {
            if (_orderedItemServices.GetOrderedItemByID(id)!=null)
            {
                _orderedItemServices.DeleteOrderedItem(id);
                return Ok();
            }
            return NotFound();
        }

        [HttpPut]
        public IActionResult UpdateOrderedItem([FromBody]OrderedItem orderedItem)
        {
            _orderedItemServices.UpdateOrderedItem(orderedItem);
            return Ok();
        }

    }
}
