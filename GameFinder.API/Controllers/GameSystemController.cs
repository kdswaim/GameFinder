using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Models.GameSystem;
using GameFinder.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameFinder.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameSystemController : ControllerBase
    {
        private readonly IGameSystemService _gameSystemService;

        public GameSystemController(IGameSystemService gameSystemService)
        {
            _gameSystemService = gameSystemService;
        }

        [HttpGet] 
        public async Task<IActionResult> Get()
        {
            List<GameSystemListItem> gamingSystems = await _gameSystemService.GetGameSystems();
            return Ok(gamingSystems);
        }
        

        [HttpGet("{id:int}")] 
        public async Task<IActionResult> Get(int id)
        {
            GameSystemDetail gamingSystem = await _gameSystemService.GetGameSystem(id);
            return Ok(gamingSystem);
        }

        //[HttpPost]
        //public async Task<IActionResult> Post(GameSystemCreate model)
        //{
            //if (!ModelState.IsValid)
           // {
            //    return BadRequest(ModelState);
            //}
            //if (await _gameSystemService.AddGameSystem(model))
            //{
                //return Ok("GameSystem created!");
            //}
           // else 
           // return StatusCode(500, "International Server Error.");
       // }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (await _gameSystemService.DeleteGameSystem(id))
            {
                return Ok("GameSystem deleted!");
            }
            else 
            return StatusCode(500, "International Server Error.");
        }

    }
}