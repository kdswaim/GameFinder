using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Services.Genres;
using Microsoft.AspNetCore.Mvc;
using GameFinder.Models.Genres;

namespace GameFinder.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenreController : ControllerBase
    {
        private readonly IGenreServices _gService;
        public GenreController(IGenreServices gService)
        {
            _gService = gService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _gService.GetGenres());
        }

        [HttpGet("(id:int)")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _gService.GetGenreById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(GenreCreate model)
        {
            if(ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if(await _gService.CreateGenre(model))
            {
                return Ok("Success!");
            }
            else
            return StatusCode(500, "Internal Server Error.");
        }

         [HttpPut("(id:int)")]
        public async Task<IActionResult> Put(GenreEdit model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (await _gService.UpdateGenre(model))
            {
                return Ok("Success!");
            }
            else {
                return StatusCode(500, "Internal Server Error.");
            }
        }

         [HttpDelete("(id:int)")]
        public async Task<IActionResult> Delete( int id)
        {
            if (id<=0)
            {
                return BadRequest("Invalid Id.");
            }
            if (await _gService.DeleteGenre(id))
            {
                return Ok("Success!");
            }
            else {
                return StatusCode(500, "Internal Server Error.");
            }
        }

    }
}