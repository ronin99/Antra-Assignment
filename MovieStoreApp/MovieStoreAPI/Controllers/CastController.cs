using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Contracts.Services;
using MovieStoreApp.Core.Models;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastController : ControllerBase
    {
        private readonly ICastServiceAsync castServiceAsync;
        public CastController(ICastServiceAsync _castServiceAsync)
        {
            this.castServiceAsync = _castServiceAsync;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //ok is for the response
            return Ok(await castServiceAsync.GetTop10CastAsync());
        }

        [HttpGet]
        [Route("search/{id:int}/{name:length(5)}")] //that length it must be 5 length //dynamic type
        public async Task<IActionResult> Get(int id,string name)
        {
            return Ok(await castServiceAsync.GetByIdAsync(id));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> create([FromBody] CastModel model)
        {
            return Ok(await castServiceAsync.AddCastAsync(model));
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> remove(int id)
        {
            return Ok(await castServiceAsync.DeleteCastAsync(id));
        }
    }
}
