using AutoMapper;
using GameFinder.Data.Contexts;
using GameFinder.Data.Entities;
using GameFinder.Models.Genres;
using Microsoft.EntityFrameworkCore;

namespace GameFinder.Services.Genres
{
    public class GenreServices : IGenreServices
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public GenreServices(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> DeleteGenre(int id)
        {
            var genre = await _context.Genres.FindAsync(id);
            if(genre is null) return false;
            
            _context.Genres.Remove(genre);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<List<GenreListItem>> GetGenres()
        {
            var genres = await _context.Genres.ToListAsync();
            var genreListItems = _mapper.Map<List<GenreListItem>>(genres);
            return genreListItems;
        }
       
        public async Task<bool> CreateGenre(GenreCreate model)
        {
            var entity = _mapper.Map<Genre>(model);
            await _context.Genres.AddAsync(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateGenre(GenreEdit model)
        {
             var genre = await _context.Genres.FirstOrDefaultAsync(g => g.Id == model.Id);
            if (genre is null) return false;

            genre.Name = model.Name;
            return await _context.SaveChangesAsync() > 0;
        }

       public async Task<GenreDetail> GetGenreById(int id)
        {
             var genre = await _context.Genres.FirstOrDefaultAsync(g => g.Id == id);
            if (genre is null) return new GenreDetail();

            return _mapper.Map<GenreDetail>(genre);
        }
      
    }
}