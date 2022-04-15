using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Contracts.Services;

namespace MovieStoreApp.WebMVC.Components
{
    public class TopMovieViewComponent: ViewComponent
    {
  
     
            IMovieServiceAsync movieService;
            public TopMovieViewComponent(IMovieServiceAsync ser)
            {
                movieService = ser;
            }
            public async Task<IViewComponentResult> InvokeAsync()
            {
                var result = await movieService.GetTop12RevenueMoviesAsync();
                return View(result);
            }
        }
    
}
