using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    interface Circle
    {
        public double Radius { get; }

        public void Circle()
        {

        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
