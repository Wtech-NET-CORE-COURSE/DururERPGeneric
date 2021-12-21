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
    /// API Controllers for company positions
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyPositionController : ControllerBase
    {
        private readonly ICompanyPositionServices _companyPositionServices;
        /// <summary>
        /// Company position controller constructor
        /// </summary>
        public CompanyPositionController(ICompanyPositionServices companyPositionServices)
        {
            _companyPositionServices = companyPositionServices;
        }

        /// <summary>
        /// Get all company positions async
        /// </summary>
        /// <returns>List of all company positions</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyPosition>>> Get()
        {
            var companyPositions = await _companyPositionServices.GetCompanyPositionsAsync();
            if (companyPositions != null)
                return Ok(companyPositions);
            return NotFound();
        }

        /// <summary>
        /// Get company position details by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyPosition>> GetByID(int id)
        {
            var companyPosition = await _companyPositionServices.GetCompanyPositionByIDAsync(id);
            if (companyPosition != null)
                return Ok(companyPosition);
            return NotFound();
        }

        /// <summary>
        /// Add new company position
        /// </summary>
        /// <param name="companyPosition"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> AddCompanyPosition([FromBody] CompanyPosition companyPosition)
        {
            await _companyPositionServices.AddCompanyPositionAsync(companyPosition);
            return Ok();
        }

        /// <summary>
        /// Remove company position by given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult RemoveCompanyPosition(int id)
        {
            if (_companyPositionServices.GetCompanyPositionByIDAsync(id) != null)
            {
                _companyPositionServices.RemoveCompanyPosition(id);
                return Ok();
            }
            return NotFound();
        }

        /// <summary>
        /// Update Company position details
        /// </summary>
        /// <param name="companyPositionToUpdated"></param>
        /// <param name="companyPosition"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult UpdateCompanyPosition([FromBody] CompanyPosition companyPositionToUpdated)
        {
            return Ok(_companyPositionServices.UpdateCompanyPosition(companyPositionToUpdated, companyPositionToUpdated));
        }
    }
}
