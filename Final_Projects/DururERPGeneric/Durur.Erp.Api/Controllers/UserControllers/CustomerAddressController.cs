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
    /// Customer address controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAddressController : ControllerBase
    {
        private ICustomerAddressServices _customerAddressServices;

        public CustomerAddressController()
        {
            _customerAddressServices = new CustomerAddressServices();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var customerAddresses  = await _customerAddressServices.GetCustomerAddressAsync();
            return Ok(customerAddresses);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var customer = _customerAddressServices.GetCustomerAddressByID(id);
            return Ok(customer);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult GetByCustomerID(int id)
        {
            var customer = _customerAddressServices.GetCustomerAddressesByCustomerID(id);
            return Ok(customer);
        }


        [HttpPost]
        public IActionResult AddCustomerAddress([FromBody] CustomerAddress customer)
        {
            _customerAddressServices.AddCustomerAddress(customer);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCustomerAddress([FromBody] CustomerAddress customer)
        {
            _customerAddressServices.UpdateCustomerAddress(customer);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomerAddress(int id)
        {
            if (_customerAddressServices.GetCustomerAddressByID(id) != null)
            {
                _customerAddressServices.DeleteCustomerAddress(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
