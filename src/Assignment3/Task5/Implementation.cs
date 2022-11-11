using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Implementation : Circle, Square
    {
        public double Radius { get; private set; }
        public double Side { get; private set; }
        public void Circle(double radius)
        {
            Radius = radius;
            

        }


        public void Square(double side)
        {
            Side = side;
        }

    }
}
