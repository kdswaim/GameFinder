using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GameFinder.Data.Entities;
using GameFinder.Models.GameSystem;

namespace GameFinder.Services.Maps
{
    public class MappingConfigurations: Profile
    {
        public MappingConfigurations()
        {
            CreateMap<GamingSystem,GameSystemCreate>().ReverseMap();
            CreateMap<GamingSystem,GameSystemDetail>().ReverseMap();
            CreateMap<GamingSystem,GameSystemListItem>().ReverseMap();
            CreateMap<GamingSystem,GameSystemUpdate>().ReverseMap();
        }
    }
}