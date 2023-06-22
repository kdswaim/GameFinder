using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Models.Genres;

namespace GameFinder.Services.Genres
{
    public interface IGenreServices
    {
        Task<bool> CreateGenre(GenreCreate model);
        Task<Boolean> UpdateGenre(GenreEdit model);
        Task<bool> DeleteGenre(int id);
        Task<GenreDetail> GetGenreById(int id);
        Task<List<GenreListItem>> GetGenres();
        
    }
}