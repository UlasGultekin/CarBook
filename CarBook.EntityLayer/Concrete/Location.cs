using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.EntityLayer.Concrete
{
    public class Location
    {
        public int LocationID { get; private set; }
        public String LocationName { get; private set; }
        public bool Status { get; private set; }
    }
}
