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
    /// Employee controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeServices _employeeServices;

        public EmployeeController()
        {
            _employeeServices = new EmployeeServices();
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
            var employee = _employeeServices.GetEmployeeByID(id);
            if (employee != null)
                return Ok(employee);
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody]Employee employee)
        {
            _employeeServices.AddEmployee(employee);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateEmployee([FromBody]Employee employee)
        {
            return Ok(_employeeServices.UpdateEmployee(employee));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            if (_employeeServices.GetEmployeeByID(id) != null)
            {
                _employeeServices.DeleteEmployee(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
