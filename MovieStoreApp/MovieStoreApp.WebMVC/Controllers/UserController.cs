using Microsoft.AspNetCore.Mvc;

namespace MovieStoreApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
