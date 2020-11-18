using OdeToFood.Data.Services;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantData _db;

        public RestaurantController(IRestaurantData db)
        {
            _db = db;
        }

        // GET: Restaurant
        public ActionResult Index()
        {
            var model = _db.GetAll();
            return View(model);
        }
    }
}