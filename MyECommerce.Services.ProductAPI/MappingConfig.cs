using AutoMapper;
using MyECommerce.Services.ProductAPI.Models;
using MyECommerce.Services.ProductAPI.Models.Dto;

namespace MyECommerce.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
