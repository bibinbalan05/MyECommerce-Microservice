
using MyECommerce.Services.OrderAPI.Models.Dto;

namespace MyECommerce.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
