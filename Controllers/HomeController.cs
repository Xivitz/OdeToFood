using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using OdeToFood.ViewModels;

namespace OdeToFood
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        private IGreeter _gretter;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _gretter = greeter;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexVm();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentMessage = _gretter.GetMessageOfTheDay();
            return View(model); 
        }

        public IActionResult Details(int Id)
        {
            var model = _restaurantData.Get(Id);

            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RestaurantEditModel model)
        {
            if (ModelState.IsValid) 
            {
                var newRestaurant = new Restaurant();
                newRestaurant.Name = model.Name;
                newRestaurant.Cuisine = model.Cuisine;

                newRestaurant = _restaurantData.Add(newRestaurant);

                return RedirectToAction(nameof(Details), new { id = newRestaurant.Id});
            }
            else
            {
                return View();
            }

        }
    }
}