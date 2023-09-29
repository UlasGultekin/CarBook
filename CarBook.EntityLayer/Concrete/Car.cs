using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.EntityLayer.Concrete
{
    public class Car
    {
        public int CarID { get; private set; }

        public string Model { get; private set; }

        public int CarCategoryID { get; private set; }

        public CarCategory CarCategory { get; private set; }

        public int BrandID { get; private set; }

        public Brand Brand { get; private set; }

        public string ImageUrl { get; private set; }

        public string GearType { get; private set; }

        public int Km { get; private set; }

        public byte PersonCount { get; private set; }

        public int Year { get; private set; }
        public int CarStatusID { get; private set; }
        public CarStatus CarStatus { get; private set; }

        public bool Status { get; private set; }
        public List<Price> Prices { get; private set; }
    }
}
