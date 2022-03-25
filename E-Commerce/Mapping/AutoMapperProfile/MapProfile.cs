using AutoMapper;
using Dtos.Dtos.ProductDtos;
using EntityLayer.Concrete;

namespace E_Commerce.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, AddProductDto>().ReverseMap();
            CreateMap<Images, UploadPRoductImage>().ReverseMap();
        }
    }
}