using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.EntityLayer.Concrete
{
    public class Price
    {
        public int PriceID { get; private set; }
        public int CarID { get; private set; }
        public Car Car { get; private set; }
        public string PriceType { get; private set; }
        public decimal PriceValue { get; private set; }


    }
}
