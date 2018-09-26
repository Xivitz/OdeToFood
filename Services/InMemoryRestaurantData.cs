using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Yakissabor" },
                new Restaurant { Id = 2, Name = "SushiCrazy" },
                new Restaurant { Id = 3, Name = "Guacamole" }
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

        List<Restaurant> _restaurants;
    }
}