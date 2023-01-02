using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Grid<T> where T : struct
    {
        private T[,,] _grid = new T[5, 5, 5];

        public T this[int index1, int index2,int index3]
        {
          
            get
            {
                return _grid[index1, index2,index3];

            }

    
            set
            {

                _grid[index1, index2, index3] = value;

            }

        }
}
