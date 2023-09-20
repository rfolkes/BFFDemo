using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JavaScriptClientHost.Controllers
{
    [Route("local/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {

        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            var name = User.FindFirst("name")?.Value ?? User.FindFirst("sub")?.Value;
            return new JsonResult(new { message = "Local API Success!", user = name });
        }
    }
}
