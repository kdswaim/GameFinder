using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Models.GameSystem;

namespace GameFinder.Services
{
    public interface IGameSystemService
    {
        public Task<bool>CreateGameSystem(GameSystemCreate model);
        public Task<bool>UpdateGameSystem(GameSystemUpdate model);
        public Task<bool>DeleteGameSystem(int id);
        public Task<GameSystemDetail>GetGameSystem(int id);
        public Task<List<GameSystemListItem>>GetGameSystems();
    }
}