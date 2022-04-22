using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Contracts.Services;

namespace MovieStoreApp.WebMVC.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreServiceAsync genreService;
        public GenreController(IGenreServiceAsync _genreService)
        {
            genreService = _genreService;
        }
        public async Task<IActionResult> Index()
        {
           var data = await genreService.GetAllAsync();
            return View(data);
        }
    }
}
