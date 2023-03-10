using Microsoft.AspNetCore.Mvc;
using SplitAppAPI.Models;
using SplitAppAPI.Services;

namespace SplitAppAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int Id)
        {
            var users = _userService.GetById(Id);
            return Ok(users);
        }

        [HttpPost("Register")]
        public IActionResult Register(User user)
        {
            _userService.Register(user);
            return Ok();
        }

        [HttpPost("UpdateUser")]
        public IActionResult UpdateUser(User user)
        {
            _userService.Update(user);
            return Ok();
        }

        [HttpDelete("DeleteUser")]
        public IActionResult DeleteUser(int Id)
        {
            _userService.Delete(Id);
            return Ok();
        }

        [HttpGet("CheckLogin")]
        public IActionResult CheckLogin(string emailAddress, string password)
        {
            User user = new User
            {
                EmailAddress = emailAddress,
                Password = password
            };
            var userData = _userService.CheckLogin(user);
            if (userData == null)
            {
                return Ok("User not exist");
            }
            else
            {
                return Ok(userData);
            }
            
        }

    }
}
