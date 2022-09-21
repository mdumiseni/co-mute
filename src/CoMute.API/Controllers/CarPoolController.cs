using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoMute.API.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class CarPoolController : ControllerBase
    {

        [HttpPost(Name = "CarPool")]
        public IActionResult CreateCarPool()
        {
            return Ok(200);
        }
    }
}
