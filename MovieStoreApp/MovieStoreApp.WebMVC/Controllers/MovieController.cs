using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieStoreApp.WebMVC.Models;
using WebApplication1.Contracts.Services;

namespace MovieStoreApp.WebMVC.Controllers
{
    public class MovieController : Controller
    {
        IMovieServiceAsync movieSerice;
        public MovieController(IMovieServiceAsync m)
        {
            movieSerice = m;
        }
            

        public async Task<IActionResult> Index()
        {
            ViewBag.Titile = "All Moviews";

            var result = await movieSerice.GetTop10RevenueMoviesAsync();
            
            return View(result);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var result =await movieSerice.GetByIdAsync(id);
            return View(result);
        }

        public IActionResult Create()
        {

            return View();
        }
        //[HttpPost]
        //public IActionResult Create(MovieModel movie)
        //{
        //    //call the repository insert method to save the movie in database
        //    if(movie.Title != null)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View(movie);
        //}
        

        
    }
}
