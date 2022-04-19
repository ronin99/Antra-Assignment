using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieStoreApp.Contracts.Services;
using MovieStoreApp.Core.Models;
using MovieStoreApp.WebMVC.Models;
using PageModel = MovieStoreApp.Core.Models.PageModel;
namespace MovieStoreApp.Controllers
{
    public class CastController : Controller
    {
        private readonly ICastServiceAsync castcontext;
        public CastController(ICastServiceAsync cser)
        {
            castcontext = cser;
        }
        public async Task<IActionResult> Index(int pg=1)
        {
            ViewBag.Title = "All Cast";
            var result = await castcontext.GetTop10CastAsync();
            const int pageSize = 10;
            if (pg < 1)
                pg = 1;

            int reCsCount = result.Count();
            var pager = new PageModel(reCsCount, pg,pageSize);
            int recSkip = (pg-1) * pageSize;
            var data = result.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;
            return View(data);
        }
        //[Route("add")]
        public IActionResult Create()
        {
            ViewBag.Gender = new SelectList(GetGenders(), "Id", "Gender");
            return View();
        }

        [NonAction]
        private IEnumerable<GenderModel> GetGenders()
        {
            return new List<GenderModel>()
            {
                new GenderModel(){Id=1, Gender="Male"},
                new GenderModel(){Id=2, Gender="Female"}
            };
        }

        [HttpPost]
        public IActionResult Create(CastModel model)
        {
            ViewBag.Gender = new SelectList(GetGenders(), "Id", "Gender");
            castcontext.AddCastAsync(model);
            //if (ModelState.IsValid)
            //{
            //    castcontext.AddCastAsync(model);
            //    return RedirectToAction("Index");
            //    //call the service to insert the data 
            //}
            //ViewBag.Gender = SelectList<GetGenders(),"Id","Gender">
            return View(model);
        }
    }
}
