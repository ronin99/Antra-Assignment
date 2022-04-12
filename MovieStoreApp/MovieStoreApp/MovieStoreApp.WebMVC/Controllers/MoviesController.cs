using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
