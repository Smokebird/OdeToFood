using OdeToFood.Data.Modals;
using OdeToFood.data3.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.data3.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{ Id = 1, Name = "Scott's Pizza", Cuisine = CuisineType.Italian},
                new Restaurant{ Id = 2, Name = "Tersiguels", Cuisine = CuisineType.French},
                new Restaurant{ Id = 3, Name = "Mango Grove", Cuisine = CuisineType.Indian}
            };
        }

        public void Add(Restaurant restaurant)
        {
            _restaurants.Add(restaurant);
            restaurant.Id = _restaurants.Max(x => x.Id) + 1;
        }

        public void Edit(Restaurant restaurant)
        {
            var index = _restaurants.FindIndex(x => x.Id == restaurant.Id);
            if(index != -1)
            {
                _restaurants[index].Name = restaurant.Name;
                _restaurants[index].Cuisine = restaurant.Cuisine;
            }
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(x => x.Id == id);
        }
    }
}
