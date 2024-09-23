using Microsoft.AspNetCore.Mvc;

namespace CrudApplication.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class HomeController
    {
        [HttpGet]
        public string GetMessage()
        {
            return "Hello Uzbekistan";
        }
    }
}
