using Assignment4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Activity
{
    public class TeacherActivity
    {
        public TeacherActivity(int id)
        {
            TrainingDbContext context = new TrainingDbContext();


            List <Course> course = context.Courses.Where(x => x.TeacherID == id).ToList();
            Course course2 = context.Courses.Where(x => x.TeacherID == id).FirstOrDefault();

            Teacher teacher = context.Teachers.Where(x => x.id == course2.TeacherID).FirstOrDefault();
            
            Console.WriteLine($"Welcome {teacher.Name}");
            
            Console.WriteLine("Assigned courses with CourseID");
            
            foreach (var item in course)
            {
              

                Console.WriteLine($"{item.Id}.{item.CourseName}");

            }

        }
    }
}
