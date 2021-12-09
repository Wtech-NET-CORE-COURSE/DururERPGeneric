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
    /// Warehouse Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseServices _warehouseServices;

        public WarehouseController(IWarehouseServices warehouseServices)
        {
            _warehouseServices = warehouseServices;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var warehouses = await _warehouseServices.GetWarehousesAsync();
            return Ok(warehouses);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var warehouse = _warehouseServices.GetWarehouseByIDAsync(id);
            return Ok(warehouse);
        }

        [HttpPost]
        public IActionResult AddWarehouse([FromBody] Warehouse warehouse)
        {
            _warehouseServices.AddWarehouseAsync(warehouse);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateWarehouse([FromBody] Warehouse warehouse)
        {
            _warehouseServices.UpdateWarehouse(warehouse,warehouse);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteWarehouse(int id)
        {
            if (_warehouseServices.GetWarehouseByIDAsync(id) != null)
            {
                _warehouseServices.RemoveWarehouse(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
