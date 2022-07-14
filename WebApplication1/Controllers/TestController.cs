using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("Method1")]
        public string Method1()
        {
            return "Method_1";
        }


        [HttpGet("Method2")]
        public string Method2()
        {
            return "Method_2";
        }

        [HttpGet("Method3")]
        public string Method3()
        {
            return "Method_3";
        }
    }
}
