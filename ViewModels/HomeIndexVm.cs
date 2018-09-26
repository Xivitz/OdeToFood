using System.Collections.Generic;

namespace OdeToFood.ViewModels
{
    public class HomeIndexVm
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentMessage { get; set; }
    }
}