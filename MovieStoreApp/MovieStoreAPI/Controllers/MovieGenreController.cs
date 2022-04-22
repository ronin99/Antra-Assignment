using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Services;
using MovieStoreApp.Core.Models;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieGenreController : ControllerBase
    {
        private readonly IMovieGenreServiceAsync movieGenreService;
        public MovieGenreController(IMovieGenreServiceAsync _movieGenreService)
        {
            movieGenreService = _movieGenreService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await movieGenreService.GetAllAsync());
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Create([FromBody] MovieGenreModel model)
        {
            return Ok(await movieGenreService.AddMovieGenerAsync(model));
        }

        [HttpDelete]
        [Route("delete/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await movieGenreService.DeleteMovieGenerAsync(id));
        }
    }
}
