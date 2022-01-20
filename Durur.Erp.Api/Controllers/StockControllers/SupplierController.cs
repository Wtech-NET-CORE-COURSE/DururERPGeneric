using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
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
        public async Task<ActionResult> AddSupplier([FromBody] Supplier supplier)
        {
            supplier.CreatedDate =DateTime.UtcNow;
            supplier.LastModifiedDate = DateTime.UtcNow;
            await _supplierServices.AddSupplierAsync(supplier);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> GetSuppliersFiltered()
        {
            try
            {
                var draw = Request.Form["draw"].FirstOrDefault();
                var start = Request.Form["start"].FirstOrDefault();
                var length = Request.Form["length"].FirstOrDefault();
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                var searchValue = Request.Form["search[value]"].FirstOrDefault();
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;
                var suppliers = await _supplierServices.GetSuppliersAsync();
                var supplierData = (from tempSupplier in suppliers select tempSupplier);
                if (!(string.IsNullOrWhiteSpace(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    supplierData = supplierData.AsQueryable().OrderBy(sortColumn+" "+sortColumnDirection);
                }
                if (!string.IsNullOrEmpty(searchValue))
                {
                    supplierData = supplierData.Where(s => s.Supplier_Name.Contains(searchValue));
                }
                recordsTotal = supplierData.Count();
                var data = supplierData.Skip(skip).Take(pageSize).ToList();
                var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
                return Ok(jsonData);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [HttpPut]
        public IActionResult UpdateSupplier([FromBody] Supplier supplier)
        {
            _supplierServices.UpdateSupplier(supplier, supplier);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplier(int id)
        {
            if (_supplierServices.GetSupplierByIDAsync(id) != null)
            {
                await _supplierServices.RemoveSupplier(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
