using Microsoft.AspNetCore.Mvc;

namespace myconsole.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "hello";
        }
    }
}
