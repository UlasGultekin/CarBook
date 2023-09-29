using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.EntityLayer.Concrete
{
    public class CarCategory
    {
        public int CarCategoryID { get; private set; }
        public string CategoryName { get; private set; }
        public string Description { get; private set; }
        public bool Status { get; private set; }
        public List<Car> Cars { get; private set; }

    }
}
