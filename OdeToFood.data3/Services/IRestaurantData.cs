using OdeToFood.Data.Modals;
using System.Collections.Generic;

namespace OdeToFood.data3.Services
{
     public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
    }
}
