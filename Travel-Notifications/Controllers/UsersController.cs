using Microsoft.AspNetCore.Mvc;
using Travel_Notifications.Common;
using Travel_Notifications.Model.Search;
using Travel_Notifications.Model.User;
using Travel_Notifications.Services;
using Travel_Notifications.Services.Interfaces;

namespace Travel_Notifications.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        
        public UsersController(IUserService usuService)
        {
            _userService = usuService;
        }

        [HttpDelete("delete")]
        public IActionResult DeleteUser(Guid userId)
        {
            return Ok(_userService.DeleteUser(userId));
        }

        [HttpPost("upsert")]
        public IActionResult UpsertUser(UserDTO user)
        {
            return Ok(_userService.UpsertUser(user));
        }

        [HttpGet("get")]
        public IActionResult GetUser(Guid userId)
        {
            return Ok(_userService.GetUser(userId));
        }

        [HttpGet("get_users")]
        public IActionResult GetUsers(Paginator page)
        {
            return Ok(_userService.GetUsers(page));
        }




    }
}
