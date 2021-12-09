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
    /// Supplier for suppliers controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierServices _supplierServices;

        public SupplierController(ISupplierServices supplierServices)
        {
            _supplierServices = supplierServices;
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
            var supplier = _supplierServices.GetSupplierByIDAsync(id);
            return Ok(supplier);
        }

        [HttpPost]
        public IActionResult AddSupplier([FromBody] Supplier supplier)
        {
            _supplierServices.AddSupplierAsync(supplier);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSupplier([FromBody] Supplier supplier)
        {
            _supplierServices.UpdateSupplier(supplier,supplier);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSupplier(int id)
        {
            if (_supplierServices.GetSupplierByIDAsync(id) != null)
            {
                _supplierServices.RemoveSupplier(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
