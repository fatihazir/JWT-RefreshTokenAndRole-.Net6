using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTRefreshToken.Controllers
{
    //[Authorize] roles can be passed by here as well.
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [Authorize(Roles = "Admin")] // "Admin, User" or "User" etc.
        [HttpGet(Name = "Test")]
        public string Get()
        {
            return "Hi";
        }
    }
}
