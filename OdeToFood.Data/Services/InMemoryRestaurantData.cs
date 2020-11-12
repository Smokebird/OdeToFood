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
            new Restaurant{ cusine = CusineType.French, Id = 1, Name = "Fancy"},
            new Restaurant{ cusine = CusineType.Indian, Id = 2, Name = "Spicy"},
            new Restaurant{ cusine = CusineType.Italian, Id = 3, Name = "Garlic"}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(x => x.Name);
        }
    }
}
