using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Models.Models;

namespace GameFinder.Services.RatingServices
{
    public interface IRatingService
    {
        Task<bool> CreateRating(RatingCreate model);
        Task<bool> UpdateRating(RatingEdit model);
        Task<bool> DeleteRating(int id);
        Task<RatingDetail> GetRating(int id);
        Task<List<RatingListItem>> GetRatings();
    }
}