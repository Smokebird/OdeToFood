using OdeToFood.Data.Modals;
using System.Data.Entity;

namespace OdeToFood.data3.Services
{
    public class OdeToFoodDbContext: DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
