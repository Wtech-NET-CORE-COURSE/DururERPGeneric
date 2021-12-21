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
    /// Location controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private ILocationServices _locationServices;

        public LocationController(ILocationServices locationServices)
        {
            _locationServices = locationServices;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var locations = await _locationServices.GetLocationsAsync();
            return Ok(locations);
        }

        [HttpGet("{id}")]
        public IActionResult GetByIDAsync(int id)
        {
            var location = _locationServices.GetLocationByIDAsync(id);
            return Ok(location);
        }

        [HttpPost]
        public IActionResult AddLocation([FromBody] Location location)
        {
            _locationServices.AddLocationAsync(location);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateLocation([FromBody] Location location)
        {
            _locationServices.UpdateLocation(location,location);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLocation(int id)
        {
            if (_locationServices.GetLocationByIDAsync(id) != null)
            {
                _locationServices.RemoveLocation(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
