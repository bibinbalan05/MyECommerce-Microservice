using MyECommerce.Services.RewardAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MyECommerce.Services.RewardAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Rewards> Rewards { get; set; }

      
    }
}
