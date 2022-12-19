using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Entities
{
    public class CourseRegistration
    {
        public int Id { get; set; }
        public int CourseId { get; set; }

        public int StudentId { get; set; }
    }
}
