using AutoMapper;
using SmartDepo.Entities.Domain;
using SmartDepo.Services.DTO;

namespace SmartDepo.Services.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDTO>()
                .ForMember(
                    dest => dest.ProductTitle,
                    opt => opt.MapFrom(src => src.Title))
                .ForMember(
                    dest => dest.ProductDescription,
                    opt => opt.MapFrom(src => src.Description))
                .ReverseMap();
            CreateMap<Category, CategoryDTO>()
                .ReverseMap();
        }
    }
}
