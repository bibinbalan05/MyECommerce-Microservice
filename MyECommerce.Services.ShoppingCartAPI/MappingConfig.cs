﻿using AutoMapper;
using MyECommerce.Services.ShoppingCartAPI.Models.Dto;
using MyECommerce.Services.ShoppingCartAPI.Models;

namespace MyECommerce.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
                config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
