using AutoMapper;
using EA.Dtos.Responses;
using EA.Entities;

namespace EA.Services.MappingProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductListDisplayResponse>().ReverseMap();
        }
    }
}
