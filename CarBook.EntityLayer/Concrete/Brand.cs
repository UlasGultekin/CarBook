using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.EntityLayer.Concrete
{
    public class Brand
    {
        public int BrandID { get; private set; }
        public string BrandName { get; private set; }
        public bool Status { get; private set; }
        public List<Car> Cars { get; private set; }
    }
}
