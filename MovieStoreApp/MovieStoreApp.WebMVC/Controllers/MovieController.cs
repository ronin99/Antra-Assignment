using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieStoreApp.WebMVC.Models;
using MovieStoreApp.Contracts.Services;
using MovieStoreApp.Core.Contract.Services;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.WebMVC.Controllers
{
   // [Route("cast")]
    public class MovieController : Controller
    {
        private readonly IMovieServiceAsync movieSerice;
        private readonly IMovieCastServiceAsync movieCastService;
        //imovecsat serviceasync 
        public MovieController(IMovieServiceAsync ser, IMovieCastServiceAsync se)
        {
            movieSerice = ser;
            movieCastService = se;
        }
            

        //[Route("/list")]
        public async Task<IActionResult> Index(int pg =1)
        {
            ViewBag.Titile = "All Moviews";


            // var result = await movieSerice.GetTop12RevenueMoviesAsync();
            //using component dont need to return result
            //var result = await movieSerice.GetTop12RevenueMoviesAsync();
            //const int pageSize = 30;
            //if (pg < 1)
            //    pg = 1;

            //int reCsCount = result.Count();
            //var pager = new PageModel(reCsCount, pg, pageSize);
            //int recSkip = (pg - 1) * pageSize;
            //var data = result.Skip(recSkip).Take(pager.PageSize).ToList();
            //this.ViewBag.Pager = pager;
            //return View(data);

            return View();
            //return ViewComponent("TopMovie");
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
