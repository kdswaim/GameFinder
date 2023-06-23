using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Models.Models;
using GameFinder.Services.GameServices;
using Microsoft.AspNetCore.Mvc;

namespace GameFinder.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameServices _gameServices;

        public GameController(IGameServices gameServices)
        {
            _gameServices = gameServices;
        }

        [HttpPost]
        public async Task<IActionResult> CreateGame(GameCreate model)
        {
            bool createGame = await _gameServices.CreateGame(model);
            return Ok(createGame);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteGame(int id)
        {
            bool deleteGame = await _gameServices.DeleteGame(id);
            return Ok(deleteGame);
        }

        [HttpGet]
        public async Task<IActionResult> GetGames()
        {
            List<GameListItem> getGames = await _gameServices.GetGames();
            return Ok(getGames);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetGame(int id)
        {
            GameDetail getGame = await _gameServices.GetGame(id);
            return Ok(getGame);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateGame(GameEdit model)
        {
            bool updateGame = await _gameServices.UpdateGame(model);
            return Ok(updateGame);
        }
    }
}