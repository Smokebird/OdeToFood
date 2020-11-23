using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private readonly IEnumerable<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant> {
            new Restaurant{ Cusine = CusineType.French, Id = 1, Name = "Fancy"},
            new Restaurant{ Cusine = CusineType.Indian, Id = 2, Name = "Spicy"},
            new Restaurant{ Cusine = CusineType.Italian, Id = 3, Name = "Garlic"}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(x => x.Name);
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(x => x.Id == id);
        }
    }
}
