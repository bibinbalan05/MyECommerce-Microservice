using MyECommerce.Services.RewardAPI.Message;

namespace MyECommerce.Services.RewardAPI.Services
{
    public interface IRewardService
    {
        Task UpdateRewards(RewardsMessage rewardsMessage);
    }
}
