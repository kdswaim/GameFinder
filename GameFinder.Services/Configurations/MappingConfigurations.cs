using AutoMapper;
using GameFinder.Data.Entities;
using GameFinder.Models.Genres;

namespace GameFinder.Services.Configurations
{
    public class MappingConfigurations : Profile
    {
        CreateMap<Genre, GenreCreate>().ReverseMap(); 
        CreateMap<Genre, GenreEdit>().ReverseMap(); 
        CreateMap<Genre, GenreDetails>().ReverseMap(); 
        CreateMap<Genre, GenreListItem>().ReverseMap();

        CreateMap<GameSystem, GameSystemCreate>().ReverseMap(); 
        CreateMap<GameSystem, GameSystemEdit>().ReverseMap(); 
        CreateMap<GameSystem, GameSystemDetails>().ReverseMap(); 
        CreateMap<GameSystem, GameSystemListItem>().ReverseMap();

        CreateMap<Game, GenreCreate>().ReverseMap(); 
        CreateMap<Game, GenreCreate>().ReverseMap(); 
        CreateMap<Game, GenreCreate>().ReverseMap(); 
        CreateMap<Game, GenreCreate>().ReverseMap();

        CreateMap<Rating, RatingCreate>().ReverseMap();
        CreateMap<Rating, RatingEdit>().ReverseMap();
        CreateMap<Rating, RatingDetails>().ReverseMap();
        CreateMap<Rating, RatingListItem>().ReverseMap();
    }
}