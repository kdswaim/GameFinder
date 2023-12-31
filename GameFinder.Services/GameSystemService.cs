using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GameFinder.Data.Contexts;
using GameFinder.Models.GameSystem;
using Microsoft.EntityFrameworkCore;
using GameFinder.Data.Entities;


namespace GameFinder.Services
{
    public class GameSystemService : IGameSystemService
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        public GameSystemService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateGameSystem(GameSystemCreate model)
        {
            var gameSystem = _mapper.Map<GamingSystem>(model);

            await _context.GamingSystems.AddAsync(gameSystem);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteGameSystem(int id)
        {
            var gameSystem = await _context.GamingSystems.FindAsync(id);
            if (gameSystem is null) return false;

            _context.GamingSystems.Remove(gameSystem);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<GameSystemDetail> GetGameSystem(int id)
        {
            var gameSystem = await _context.GamingSystems.SingleOrDefaultAsync(x => x.Id == id);
            
            if (gameSystem is null) return new GameSystemDetail{};

            return _mapper.Map<GameSystemDetail>(gameSystem);
        }

        public async Task<List<GameSystemListItem>> GetGameSystems()
        {
            var gameSystems = await _context.GamingSystems.ToListAsync();

            var gameSystemListItems = _mapper.Map<List<GameSystemListItem>>(gameSystems);

            return gameSystemListItems;
        }

        public async Task<bool> UpdateGameSystem(GameSystemUpdate model)
        {
            var gameSystem = await _context.GamingSystems.SingleOrDefaultAsync(x => x.Id == model.Id);

            if (gameSystem is null) return false;

            _context.GamingSystems.Remove(gameSystem);

            return await _context.SaveChangesAsync() > 0;
        }
    }
}