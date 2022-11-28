using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class StringHelper
    {


        public string Append(string a, string b, string c, string d)
        {

          

            if( c == String.Empty && d == String.Empty)
            {
                return a + b;
            }
          
            else if (d == String.Empty)
            {
                return a + b + c;
            }
            
            else
            {
                return a + b + c + d;
            }
           
        }
    }
}
