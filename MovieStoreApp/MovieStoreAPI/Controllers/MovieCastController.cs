using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Services;
using MovieStoreApp.Core.Models;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieCastController : ControllerBase
    {
        private readonly IMovieCastServiceAsync movieCastServiceAsync;
        public MovieCastController(IMovieCastServiceAsync _movieCastServiceAsync)
        {
            movieCastServiceAsync = _movieCastServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await movieCastServiceAsync.GetAllAsync());
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add([FromBody] MovieCastModel model)
        {
            return Ok(await movieCastServiceAsync.AddMovieCastAsync(model));
        }

        [HttpDelete]
        [Route("delete/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await movieCastServiceAsync.DeleteMovieCastAsync(id));
        }

        [HttpGet]
        [Route("serach/{id:int}")]
        public async Task<IActionResult> Search(int id)
        {
            return Ok(await movieCastServiceAsync.GetMovieCastByIdAsync(id));
        }
    }
}
