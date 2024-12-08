using MyECommerce.Services.EmailAPI.Message;
using MyECommerce.Services.EmailAPI.Models.Dto;

namespace MyECommerce.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
