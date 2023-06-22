using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Models.Models;

namespace GameFinder.Services.GameServices
{
    public interface IGameServices
    {
        Task<bool> CreateGame(GameCreate model);
        Task<bool> UpdateGame(GameEdit model);
        Task<bool> DeleteGame(int id);
        Task<GameDetail> GetGame(int id);
        Task<List<GameListItem>> GetGames();
    }
}