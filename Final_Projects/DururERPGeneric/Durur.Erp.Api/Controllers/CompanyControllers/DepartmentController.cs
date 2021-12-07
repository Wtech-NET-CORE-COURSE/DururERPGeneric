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
    /// API controller for departments
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        readonly IDepartmentServices _departmentServices;
        /// <summary>
        /// Department controller constructor
        /// </summary>
        public DepartmentController(IDepartmentServices departmentServices)
        {
            _departmentServices = departmentServices;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> Get()
        {
            var departments = await _departmentServices.GetDepartmentsAsync();
            if (departments != null)
                return Ok(departments);
            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetByID(int id)
        {
            var department = _departmentServices.GetDepartmentByIDAsync(id);
            if (department != null)
                return Ok(department);
            return NotFound();
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<IEnumerable<Department>>> GetByLocationID(int id)
        {
            var departments = await _departmentServices.GetDepartmentsByLocationIDAsync(id);
            return Ok(departments);
        }

        [HttpGet]
        [Route("[action]/{name}")]
        public async Task<ActionResult<Department>> GetByName(string name)
        {
            var department = await _departmentServices.GetDepartmentByName(name);
            if (department != null)
                return Ok(department);
            return NotFound();
        }


        [HttpPost]
        public async Task<ActionResult> AddDepartment([FromBody] Department department)
        {
            await _departmentServices.AddDepartmentAsync(department);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteDepartment(int id)
        {
            if (await _departmentServices.GetDepartmentByIDAsync(id) != null)
            {
                _departmentServices.RemoveDepartment(id);
                return Ok();
            }
            return NotFound();
        }


        [HttpPut]
        public IActionResult UpdateDepartment([FromBody] Department departmentToUpdate,[FromBody] Department department)
        {
            return Ok(_departmentServices.UpdateDepartment(departmentToUpdate,department));
        }

    }
}
