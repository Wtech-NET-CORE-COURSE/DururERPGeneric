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
    /// Customer controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServices _customerServices;

        public CustomerController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var customers = await _customerServices.GetCustomersAsync();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var customer = _customerServices.GetCustomerByIDAsync(id);
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult AddCustomer([FromBody] Customer customer)
        {
            _customerServices.AddCustomer(customer);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCustomer([FromBody] Customer customer)
        {
            _customerServices.UpdateCustomer(customer,customer);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            if (_customerServices.GetCustomerByIDAsync(id) != null)
            {
                _customerServices.RemoveCustomer(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
