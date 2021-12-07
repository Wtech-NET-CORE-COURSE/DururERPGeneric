using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Durur.Erp.Api.Controllers
{
    /// <summary>
    /// Employee's job controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobServices _jobServices;

        public JobController(IJobServices jobServices)
        {
            _jobServices = jobServices;
        }

        [HttpGet]
        public async Task<ActionResult<Job>> GetAllAsync()
        {
            var jobs = await _jobServices.GetJobsAsync();
            return Ok(jobs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Job>> GetByID(int id)
        {
            var job =await _jobServices.GetJobByID(id);
            if (job != null)
                return Ok(job);
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> AddJob([FromBody] Job job)
        {
            await _jobServices.AddJobAsync(job);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteJob(int id)
        {
            if (_jobServices.GetJobByID(id) != null)
            {
                _jobServices.RemoveJob(id);
                return Ok();
            }
            return NotFound();
        }

        [HttpPut]
        public IActionResult UpdateJob([FromBody] Job job)
        {
            return Ok(_jobServices.UpdateJob(job,job));
        }
    }
}
