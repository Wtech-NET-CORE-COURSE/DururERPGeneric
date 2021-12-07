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
    /// User Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserServices _userServices;

        public UserController()
        {
            _userServices = new UserServices();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var users = await _userServices.GetUsersAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var user = _userServices.GetUserByID(id);
            return Ok(user);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            _userServices.AddUser(user);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateUser([FromBody] User user)
        {
            _userServices.UpdateUser(user);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            if (_userServices.GetUserByID(id) != null)
            {
                _userServices.DeleteUser(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
