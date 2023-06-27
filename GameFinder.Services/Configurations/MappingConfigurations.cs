using AutoMapper;
using GameFinder.Models.Genres;
using GameFinder.Data.Entities;
using GameFinder.Models.Models;
using GameFinder.Models.GameSystem;

namespace GameFinder.Services.Configurations
{
    public class MappingConfigurations : Profile
    {
     public MappingConfigurations()
     {
        CreateMap<Genre,GenreCreate>().ReverseMap();
        CreateMap<Genre, GenreEdit>().ReverseMap(); 
        CreateMap<Genre, GenreDetail>().ReverseMap(); 
        CreateMap<Genre, GenreListItem>().ReverseMap();

        CreateMap<GamingSystem, GameSystemCreate>().ReverseMap(); 
        CreateMap<GamingSystem, GameSystemUpdate>().ReverseMap(); 
        CreateMap<GamingSystem, GameSystemDetail>().ReverseMap(); 
        CreateMap<GamingSystem, GameSystemListItem>().ReverseMap();

        CreateMap<Game, GameCreate>().ReverseMap(); 
        CreateMap<Game, GameDetail>().ReverseMap(); 
        CreateMap<Game, GameEdit>().ReverseMap(); 
        CreateMap<Game, GameListItem>().ReverseMap();

        CreateMap<Rating, RatingCreate>().ReverseMap();
        CreateMap<Rating, RatingEdit>().ReverseMap();
        CreateMap<Rating, RatingDetail>().ReverseMap();
        CreateMap<Rating, RatingListItem>().ReverseMap();
     }
    }
}