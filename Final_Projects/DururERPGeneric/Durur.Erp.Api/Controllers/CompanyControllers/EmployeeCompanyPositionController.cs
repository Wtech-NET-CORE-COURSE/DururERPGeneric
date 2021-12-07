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
    /// Company positions for employees conroller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeCompanyPositionController : ControllerBase
    {
        private IEmployeeCompanyPositionServices _employeeCompanyPositionServices;

        /// <summary>
        /// Employee position controller constructor
        /// </summary>
        public EmployeeCompanyPositionController()
        {
            _employeeCompanyPositionServices = new EmployeeCompanyPositionServices();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var positions = await _employeeCompanyPositionServices.GetEmployeeCompanyPositionsAsync();
            return Ok(positions);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetByCompanyPositionID(int id)
        {
            var positions = await _employeeCompanyPositionServices.GetEmployeePositionsByCompanyPositionIDAsync(id);
            return Ok(positions);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetByCompanyDepartmentID(int id)
        {
            var positions = await _employeeCompanyPositionServices.GetEmployeePositionsByDepartmentIDAsync(id);
            return Ok(positions);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetByEmployeeID(int id)
        {
            var positions = await _employeeCompanyPositionServices.GetEmployeePositionsByEmployeeIDAsync(id);
            return Ok(positions);
        }

        [HttpPost]
        public IActionResult AddPosition([FromBody] EmployeeCompanyPosition employeeCompanyPosition)
        {
            _employeeCompanyPositionServices.AddEmployeePosition(employeeCompanyPosition);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeletePosition([FromBody] EmployeeCompanyPosition employeeCompanyPosition)
        {
            _employeeCompanyPositionServices.DeleteEmployeePosition(employeeCompanyPosition);
            return Ok();
        }


    }
}
