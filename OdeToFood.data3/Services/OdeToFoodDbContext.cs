using OdeToFood.Data.Modals;
using System.Data.Entity;

namespace OdeToFood.data3.Services
{
    class OdeToFoodDbContext: DbContext
    {
        public DbSet<Restaurant> _db { get; set; }
    }
}
