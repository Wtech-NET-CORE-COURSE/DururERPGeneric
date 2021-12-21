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
    /// Inventory-stock controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryServices _inventoryServices;

        public InventoryController(IInventoryServices inventoryServices)
        {
            _inventoryServices = inventoryServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var inventories = await _inventoryServices.GetInventoriesAsync();
            return Ok(inventories);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult GetByProductID(int id)
        {
            var inventory = _inventoryServices.GetInventoryByProductIDAsync(id);
            return Ok(inventory);
        }


        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult GetByWarehouseID(int id)
        {
            var inventory = _inventoryServices.GetInventoryByWarehouseIDAsync(id);
            return Ok(inventory);
        }

        [HttpPost]
        public IActionResult AddInventory([FromBody] Inventory inventory)
        {
            _inventoryServices.AddInventoryAsync(inventory);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateInventory([FromBody] Inventory inventory)
        {
            _inventoryServices.UpdateInventory(inventory,inventory);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteInventory([FromBody] Inventory inventory)
        {
            if (inventory != null)
            {
                _inventoryServices.RemoveInventory(inventory);
                return Ok();
            }
            return NotFound();
        }
    }
}
