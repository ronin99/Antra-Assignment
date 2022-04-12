using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieStoreApp.WebMVC.Models;

namespace MovieStoreApp.WebMVC.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Titile = "All Moviews";

            List<MovieModel> lstMovies = new List<MovieModel>
            {
                new MovieModel(){Id = 1,  Title ="Demo1", Duration=165, ReleaseDate=DateTime.Now.AddYears(-5).ToShortDateString(), Description="Hello",PosterUrl="Imag"},

                new MovieModel(){Id = 2,  Title ="Demo2", Duration=165, ReleaseDate=DateTime.Now.AddYears(-5).ToShortDateString(), Description="Hello",PosterUrl="Imag"},

                new MovieModel(){Id = 3,  Title ="Demo3", Duration=165, ReleaseDate=DateTime.Now.AddYears(-5).ToShortDateString(), Description="Hello",PosterUrl="Imag"},

                new MovieModel(){Id = 4,  Title ="Demo4", Duration=165, ReleaseDate=DateTime.Now.AddYears(-5).ToShortDateString(), Description="Hello",PosterUrl="Imag"}
            };
            return View(lstMovies);
        }

        public IActionResult Detail(int id)
        {
            return View();
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(MovieModel movie)
        {
            //call the repository insert method to save the movie in database
            if(movie.Title != null)
            {
                return RedirectToAction("Index");
            }
            return View(movie);
        }
        

        
    }
}
