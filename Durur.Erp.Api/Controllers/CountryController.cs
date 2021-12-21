using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Durur.Erp.Api.Controllers
{    /// <summary>
     /// Country Controller
     /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private ICountryServices _countryServices;

        public CountryController(ICountryServices countryServices)
        {
            _countryServices = countryServices;
        }

        [HttpGet]
        public async Task<ActionResult<Country>> GetAllAsync()
        {
            var countries = await _countryServices.GetCountriesAsync();
            return Ok(countries);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Country>> GetByID(int id)
        {
            var country = await _countryServices.GetCountryByIDAsync(id);
            return Ok(country);
        }

        [HttpPost]
        public async Task<ActionResult> AddCountry([FromBody] Country country)
        {
            await _countryServices.AddCountryAsync(country);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCountry([FromBody] Country country)
        {
            //_countryServices.UpdateCountry(country);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCountry(int id)
        {
            if (_countryServices.GetCountryByIDAsync(id) != null)
            {
                _countryServices.RemoveCountry(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
