using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Models.Models;
using GameFinder.Services.RatingServices;
using Microsoft.AspNetCore.Mvc;

namespace GameFinder.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RatingControllers : ControllerBase
    {
        private readonly IRatingService _ratingService;

        public RatingControllers(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRating(RatingCreate model)
        {
            bool ratingCreate = await _ratingService.CreateRating(model);
            return Ok(ratingCreate);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteRating(int id)
        {
            bool ratingDelete = await _ratingService.DeleteRating(id);
            return Ok(ratingDelete);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAllRatingsForGame(int id)
        {
            List<RatingListItem> reviewsForGame = await _ratingService.GetRatings(id);
            return Ok(reviewsForGame);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetRating(int id)
        {
            RatingDetail rating = await _ratingService.GetRating(id);
            return Ok(rating);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRating(RatingEdit model)
        {
            bool updateRating = await _ratingService.UpdateRating(model);
            return Ok(updateRating);
        }
    }
}