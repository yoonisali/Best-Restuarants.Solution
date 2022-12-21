using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Models
{
    public class BestRestaurantsContext : DbContext
    {
        public DbSet<Cuisine> Categories { get; set; }
        public DbSet<Restaurant> Items { get; set; }

        public BestRestaurantsContext(DbContextOptions options) : base(options) { }
    }
}