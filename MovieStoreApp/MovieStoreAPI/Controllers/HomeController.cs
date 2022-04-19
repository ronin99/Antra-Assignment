using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]//will hope you to get in to this method
        [Route("message")]
        public string GetWelcomeMessage()
        {
            return "Welcome to web api";
        }

        [HttpGet]//will hope you to get in to this method
        [Route("country")]
        [Route("countryname")]
        public string GetCountryName()
        {
            return "USA";
        }



    }
}
