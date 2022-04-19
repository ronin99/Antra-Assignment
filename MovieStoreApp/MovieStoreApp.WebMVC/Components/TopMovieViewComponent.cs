using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Contracts.Services;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.WebMVC.Components
{
    public class TopMovieViewComponent: ViewComponent
    {
  
     
            IMovieServiceAsync movieService;
            public TopMovieViewComponent(IMovieServiceAsync ser)
            {
                movieService = ser;
            }
            public async Task<IViewComponentResult> InvokeAsync(int pg=1)
            {
                var result = await movieService.GetTop12RevenueMoviesAsync();
            const int pageSize = 30;
            if (pg < 1)
                pg = 1;

            int reCsCount = result.Count();
            var pager = new PageModel(reCsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = result.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;
            return View(data);
            //return View(result);
        }
        }
    
}
