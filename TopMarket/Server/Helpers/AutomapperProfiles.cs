using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMarket.Shared.Entities;

namespace TopMarket.Server.Helpers
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<Person, Person>()
                .ForMember(x => x.Picture, option => option.Ignore());

            CreateMap<Product, Product>()
                .ForMember(x => x.Poster, option => option.Ignore());
        }
    }
}
