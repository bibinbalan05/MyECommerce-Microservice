using MyECommerce.Services.ShoppingCartAPI.Models.Dto;

namespace MyECommerce.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
