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
    /// Customer address controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAddressController : ControllerBase
    {
        private readonly ICustomerAddressServices _customerAddressServices;

        public CustomerAddressController(ICustomerAddressServices customerAddressServices)
        {
            _customerAddressServices = customerAddressServices;
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
            var customer = _customerAddressServices.GetCustomerAddressByIDAsync(id);
            return Ok(customer);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult GetByCustomerID(int id)
        {
            var customer = _customerAddressServices.GetCustomerAddressesByCustomerIDAsync(id);
            return Ok(customer);
        }


        [HttpPost]
        public IActionResult AddCustomerAddress([FromBody] CustomerAddress customerAddress)
        {
            _customerAddressServices.AddCustomerAddressAsync(customerAddress);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCustomerAddress([FromBody] CustomerAddress customerAddress)
        {
            _customerAddressServices.UpdateCustomerAddress(customerAddress,customerAddress);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomerAddress(int id)
        {
            if (_customerAddressServices.GetCustomerAddressByIDAsync(id) != null)
            {
                _customerAddressServices.RemoveCustomerAddress(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
