using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Contracts.Services;

namespace MovieStoreApp.Controllers
{
    public class CastController : Controller
    {
        ICastServiceAsync castcontext;
        public CastController(ICastServiceAsync cser)
        {
            castcontext = cser;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "All Cast";
            var result = await castcontext.GetTop10CastAsync();

            return View(result);
        }
    }
}
