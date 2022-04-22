using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Contracts.Services;
using MovieStoreApp.Core.Models;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieServiceAsync movieServiceAsync;
        public MovieController(IMovieServiceAsync _movieServiceAsync)
        {
           this.movieServiceAsync = _movieServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await movieServiceAsync.GetTop12RevenueMoviesAsync());
        }

        [HttpGet]
        [Route("search/{id:int}")]
        public async Task<IActionResult> Search(int id)
        {
            return Ok(await movieServiceAsync.GetByIdAsync(id));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add([FromBody] MovieResponseModel model)
        {
            return  Ok(await movieServiceAsync.AddMovieAsync(model));
        }
        
        [HttpDelete]
        [Route("delete/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await movieServiceAsync.DeleteMovieAsync(id));
        }

    }
}
