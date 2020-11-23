using OdeToFood.data3.Modals;

namespace OdeToFood.Data.Modals
{
    public class Restaurant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public CuisineType Cuisine { get; set; }
    }
}
