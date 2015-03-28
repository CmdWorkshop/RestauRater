using System.Data.Entity;

namespace RestaurantApp.Models
{
    public class RestauRaterDB : DbContext
    {
        public DbSet<Dish> Dishes { get; set; }
    }
}