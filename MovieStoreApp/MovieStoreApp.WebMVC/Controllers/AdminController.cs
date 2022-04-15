using Microsoft.AspNetCore.Mvc;

namespace MovieStoreApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
