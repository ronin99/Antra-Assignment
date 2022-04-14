using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contracts.Services;

namespace WebApplication1.Controllers
{
    public class CastController : Controller
    {
        ICastServiceAsync c;
        public CastController(ICastServiceAsync a)
        {
            c = a;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "All Cast";
            var result = await c.GetTop10CastAsync();

            return View(result);
        }
    }
}
