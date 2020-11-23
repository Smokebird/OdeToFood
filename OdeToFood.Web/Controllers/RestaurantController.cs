using System.Web.Mvc;
using OdeToFood.data3.Services;

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

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = _db.Get(id);
            if(model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
    }
}