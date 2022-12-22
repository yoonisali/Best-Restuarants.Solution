using System.Collections.Generic;

namespace BestRestaurants.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }

        public string Name { get; set; }
        public string Rating { get; set; }
        public string Cost { get; set; }
        public int CuisineId { get; set; }
        public Cuisine Cuisine { get; set; }
        public List<Review> Reviews { get; set; }
    }
}