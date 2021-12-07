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
    /// Location controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private ILocationServices _locationServices;

        public LocationController()
        {
            _locationServices = new LocationServices();
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var locations = await _locationServices.GetLocationsAsync();
            return Ok(locations);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var location = _locationServices.GetLocationByID(id);
            return Ok(location);
        }

        [HttpPost]
        public IActionResult AddLocation([FromBody] Location location)
        {
            _locationServices.AddLocation(location);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateLocation([FromBody] Location location)
        {
            _locationServices.UpdateLocation(location);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLocation(int id)
        {
            if (_locationServices.GetLocationByID(id) != null)
            {
                _locationServices.DeleteLocation(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
