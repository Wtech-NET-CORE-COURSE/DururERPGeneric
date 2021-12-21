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
    /// User Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllAsync()
        {
            var users = await _userServices.GetUsersAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetByID(int id)
        {
            var user =await _userServices.GetUserByIDAsync(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult> AddUser([FromBody] User user)
        {
            await _userServices.AddUserAsync(user);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateUser([FromBody] User user)
        {
            _userServices.UpdateUser(user,user);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            if (_userServices.GetUserByIDAsync(id) != null)
            {
                _userServices.RemoveUser(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
