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
    /// Warehouse Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private IWarehouseServices _warehouseServices;

        public WarehouseController()
        {
            _warehouseServices = new WarehouseServices();
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
            var warehouse = _warehouseServices.GetWarehouseByID(id);
            return Ok(warehouse);
        }

        [HttpPost]
        public IActionResult AddWarehouse([FromBody] Warehouse warehouse)
        {
            _warehouseServices.AddWarehouse(warehouse);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateWarehouse([FromBody] Warehouse warehouse)
        {
            _warehouseServices.UpdateWarehouse(warehouse);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteWarehouse(int id)
        {
            if (_warehouseServices.GetWarehouseByID(id) != null)
            {
                _warehouseServices.DeleteWarehouse(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
