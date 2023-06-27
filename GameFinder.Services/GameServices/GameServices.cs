using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GameFinder.Data.Contexts;
using GameFinder.Data.Entities;
using GameFinder.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace GameFinder.Services.GameServices
{
    public class GameServices : IGameServices
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public GameServices(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateGame(GameCreate model)
        {
            var game = _mapper.Map<Game>(model);

            await _context.Games.AddAsync(game);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteGame(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if(game is null)
                return false;

            _context.Games.Remove(game);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<GameListItem>> GetGames()
        {
            var games = await _context.Games.Include(g=> g.Ratings).ToListAsync();
            var gameListItems = _mapper.Map<List<GameListItem>>(games);

            return gameListItems;
        }

        public async Task<GameDetail> GetGame(int id)
        {
            var game = await _context.Games.Include(g=> g.Ratings).FirstOrDefaultAsync(x=>x.Id == id);
            if(game is null)
                return new GameDetail();

            var gameDetail = _mapper.Map<GameDetail>(game);

            return gameDetail;
        }

        public async Task<bool> UpdateGame(GameEdit model)
        {
            var game = await _context.Games.FirstOrDefaultAsync(x=>x.Id == model.Id);

            var conversion = _mapper.Map<GameEdit,Game>(model, game);
            _context.Games.Update(conversion);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}