using OdeToFood.Data.Modals;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.data3.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext _db;

        public SqlRestaurantData(OdeToFoodDbContext db)
        {
            _db = db;
        }

        public void Add(Restaurant restaurant)
        {
            _db.Restaurants.Add(restaurant);
            _db.SaveChanges();
        }

        public void Edit(Restaurant restaurant)
        {
            _db.Entry(restaurant).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public Restaurant Get(int id)
        {
            return _db.Restaurants.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _db.Restaurants.OrderBy(x => x.Name);
        }
    }
}
