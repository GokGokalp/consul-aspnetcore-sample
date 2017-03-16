using Microsoft.AspNetCore.Mvc;

namespace ConsulSampleAspNetCore.Controllers
{
    [Route("[controller]")]
    public class HelpController : Controller
    {
        [HttpGet("")]
        public string Ping()
        {
            return "OK";
        }
    }
}