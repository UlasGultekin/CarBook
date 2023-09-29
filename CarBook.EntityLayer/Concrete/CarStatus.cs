using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.EntityLayer.Concrete
{
    public class CarStatus
    {
        public int CarStatusID { get; private set; }
        public string CarStatusName { get; private set; }
        public List<Car> Cars { get; private set; }
    }
}
