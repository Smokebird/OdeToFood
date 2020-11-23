using OdeToFood.data3.Modals;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Data.Modals
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public CuisineType Cuisine { get; set; }
    }
}
