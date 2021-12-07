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
    /// Customer controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerServices _customerServices;

        public CustomerController()
        {
            _customerServices = new CustomerServices();
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
            var customer = _customerServices.GetCustomerByID(id);
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
            _customerServices.UpdateCustomer(customer);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            if (_customerServices.GetCustomerByID(id) != null)
            {
                _customerServices.DeleteCustomer(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
