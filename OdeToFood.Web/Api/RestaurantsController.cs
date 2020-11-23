
using OdeToFood.Data.Modals;
using OdeToFood.data3.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace OdeToFood.Web.Api
{
    public class RestaurantsController : ApiController
    {

        public readonly IRestaurantData _db;

        public RestaurantsController(IRestaurantData db)
        {
            _db = db;
        }

        public IEnumerable<Restaurant> Get()
        {
            var model = _db.GetAll();
            return model;
        }
    }
}
