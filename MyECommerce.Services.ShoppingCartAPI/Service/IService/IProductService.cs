using MyECommerce.Services.ShoppingCartAPI.Models.Dto;

namespace MyECommerce.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
