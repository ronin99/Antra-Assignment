using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Contracts.Services;
using MovieStoreApp.Core.Models;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerController : ControllerBase
    {
        private readonly IGenreServiceAsync genreService;
        public GenerController(IGenreServiceAsync _genreService)
        {
            this.genreService = _genreService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await genreService.GetAllAsync());
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Create([FromBody] GenreModel model)
        {
            return Ok(await genreService.AddGenreAsync(model));
        }

        [HttpDelete]
        [Route("delete/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await genreService.DeleteGenreAsync(id));
        }
    }
}
