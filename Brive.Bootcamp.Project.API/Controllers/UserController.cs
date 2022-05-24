using Brive.Bootcamp.Project.API.Models;
using Brive.Bootcamp.Project.API.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp.Project.API.Controllers
{
    [EnableCors("BootcampProject")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("Login")]
        public ActionResult<bool> Login(User user)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _userService.Authentication(user));
            }
            catch
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
        }
    }
}
