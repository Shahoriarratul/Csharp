using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public class ShoppingCart
    {
        public CartItem[] Items { get; set; }
        public double Discount { get; set; }

        public ShoppingCart(int size)
        {
          var Items = new CartItem[size];
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach(CartItem i in Items)
            {
                total += i.Price * i.Quantity;
            }

            return total;
        }
    }
}
