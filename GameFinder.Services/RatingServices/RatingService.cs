using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GameFinder.Data.Contexts;
using GameFinder.Data.Entities;
using GameFinder.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace GameFinder.Services.RatingServices
{
    public class RatingService : IRatingService
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;
        
        public RatingService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateRating(RatingCreate model)
        {
            var rating = _mapper.Map<Rating>(model);
            
            await _context.Ratings.AddAsync(rating);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteRating(int id)
        {
            var rating = await _context.Ratings.FindAsync(id);
            if(rating is null)
                return false;
            
            _context.Ratings.Remove(rating);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<RatingListItem>> GetRatings(int id)
        {
            var ratings = await _context.Ratings.Where(r => r.GameId == id).ToListAsync();
            var ratingListItems = _mapper.Map<List<RatingListItem>>(ratings);

            return ratingListItems;
        }

        public async Task<RatingDetail> GetRating(int id)
        {
            var rating = await _context.Ratings.FirstOrDefaultAsync(x=>x.Id == id);
            if(rating is null)
                return new RatingDetail();
            
            var ratingDetail = _mapper.Map<RatingDetail>(rating);

            return ratingDetail;
        }

        public async Task<bool> UpdateRating(RatingEdit model)
        {
            var rating = await _context.Ratings.FirstOrDefaultAsync(x=>x.Id == model.Id);

            var conversion = _mapper.Map<RatingEdit,Rating>(model, rating);
            _context.Ratings.Update(conversion);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}