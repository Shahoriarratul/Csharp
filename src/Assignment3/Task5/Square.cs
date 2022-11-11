using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    interface Square
    {
        public double Side { get;  }

        public void Square()
        {

        }
        public double CalculateArea()
        {
            return Side * Side;
        }
    }
}
