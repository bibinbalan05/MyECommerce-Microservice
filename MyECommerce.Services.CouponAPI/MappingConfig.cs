using AutoMapper;
using MyECommerce.Services.CouponAPI.Models;
using MyECommerce.Services.CouponAPI.Models.Dto;


namespace MyECommerce.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
