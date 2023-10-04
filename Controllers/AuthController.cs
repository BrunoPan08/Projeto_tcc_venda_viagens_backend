using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TccAplicacao.models;

namespace TccAplicacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static User user = new User();
        [HttpPost("register")]
        public ActionResult<User> Register(UserDto request) 
        {
            string password
                = BCrypt.Net.BCrypt.HashPassword(request.Password);

            user.Username = request.Username;
            user.Password = password;

            return Ok(user);
        }
    }
}
