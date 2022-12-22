using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.utility
{
    public class plusAttendence
    {
        public void GiveAttendence(TrainingDbContext context)
        {
            Console.WriteLine("To give attendence type Id of your enrolled course");
            int id = Convert.ToInt32(Console.ReadLine());


        }
    }
}
