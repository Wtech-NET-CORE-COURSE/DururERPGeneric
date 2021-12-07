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
    /// Supplier for suppliers controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private ISupplierServices _supplierServices;

        public SupplierController()
        {
            _supplierServices=new SupplierServices();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var suppliers = await _supplierServices.GetSuppliersAsync();
            return Ok(suppliers);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var supplier = _supplierServices.GetSupplierByID(id);
            return Ok(supplier);
        }

        [HttpPost]
        public IActionResult AddSupplier([FromBody] Supplier supplier)
        {
            _supplierServices.AddSupplier(supplier);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSupplier([FromBody] Supplier supplier)
        {
            _supplierServices.UpdateSupplier(supplier);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSupplier(int id)
        {
            if (_supplierServices.GetSupplierByID(id) != null)
            {
                _supplierServices.DeleteSupplier(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
