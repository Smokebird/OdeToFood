using System.Web.Mvc;
using OdeToFood.Data.Modals;
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
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _db.Add(restaurant);
                return RedirectToAction("Details", new { id = restaurant.Id});
            }

            return View(restaurant);
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

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = _db.Get(id);
            if(model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _db.Edit(restaurant);
                return RedirectToAction("Details", new { id = restaurant.Id });
            }
            return View(restaurant);
        }
    }
}