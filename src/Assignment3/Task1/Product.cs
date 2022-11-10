using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }

        public Product (string name)
        {
            Name = name;

        }
        public Product(string name,double price)
        {
            Name=name;
            Price = price;
        }
        public Product():this("bottle",100)
        {

        }
       
        public void show()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Price);
        }

    }
}
