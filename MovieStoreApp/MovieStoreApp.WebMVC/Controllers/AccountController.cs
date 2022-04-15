using Microsoft.AspNetCore.Mvc;

namespace MovieStoreApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
