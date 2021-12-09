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
    /// Employee controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _employeeServices;

        public EmployeeController(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var employees = await _employeeServices.GetEmployeesAsync();
            return Ok(employees);
        }


        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var employee = _employeeServices.GetEmployeeByIDAsync(id);
            if (employee != null)
                return Ok(employee);
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody]Employee employee)
        {
            _employeeServices.AddEmployeeAsync(employee);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateEmployee([FromBody]Employee employee)
        {
            return Ok(_employeeServices.UpdateEmployee(employee,employee));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            if (_employeeServices.GetEmployeeByIDAsync(id) != null)
            {
                _employeeServices.RemoveEmployee(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
