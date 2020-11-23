using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public CusineType Cusine { get; set; }
    }
}
