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
        public async Task<ActionResult<IEnumerable<Location>>> GetAllAsync()
        {
            var locations = await _locationServices.GetLocationsAsync();
            return Ok(locations);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<IEnumerable<Location>>> GetByCountryID(int id)
        {
            var locations = await _locationServices.GetByCountryID(id);
            return Ok(locations);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<IEnumerable<Location>>> GetWithCountries()
        {
            var rawlocations = await _locationServices.GetLocationsWithCountries();
            var processedlocations = rawlocations.Select(l => new
            {
                l.Location_ID,
                l.City,
                l.Country.Country_ID,
                l.Country.Country_Name
            });
            return Ok(processedlocations);
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
