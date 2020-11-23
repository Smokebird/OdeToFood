using OdeToFood.Data.Modals;
using System.Collections.Generic;

namespace OdeToFood.data3.Services
{
     public interface IRestaurantData
    {
        void Add(Restaurant restaurant);
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
    }
}
