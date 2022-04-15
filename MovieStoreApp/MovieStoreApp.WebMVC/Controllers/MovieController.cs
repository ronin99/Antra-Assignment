using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieStoreApp.WebMVC.Models;
using MovieStoreApp.Contracts.Services;
using MovieStoreApp.Core.Contract.Services;

namespace MovieStoreApp.WebMVC.Controllers
{
    public class MovieController : Controller
    {
        IMovieServiceAsync movieSerice;
        IMovieCastServiceAsync movieCastService;
        //imovecsat serviceasync 
        public MovieController(IMovieServiceAsync ser, IMovieCastServiceAsync se)
        {
            movieSerice = ser;
            movieCastService = se;
        }
            

        public async Task<IActionResult> Index()
        {
            ViewBag.Titile = "All Moviews";

            //var result = await movieSerice.GetTop12RevenueMoviesAsync();
            //using component dont need to return result
            
            return View();
        }

        public async Task<IActionResult> Detail(int id)
        {
            var result =await movieSerice.GetByIdAsync(id);
            result.MovieCasts = await movieCastService.GetAllByMovieIdAsync(id);
           
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
