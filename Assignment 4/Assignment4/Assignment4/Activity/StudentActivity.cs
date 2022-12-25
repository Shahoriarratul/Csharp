using Assignment4.Entities;
using Assignment4.Migrations;
using Assignment4.utility;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Activity
{
    public class StudentActivity
    {
        public StudentActivity(int id)
        {
        
            TrainingDbContext context = new TrainingDbContext();

            Student student = context.Students.Where(x => x.Id == id)
              .Include(x => x.StudentCourses)
              .FirstOrDefault();

            Console.WriteLine($"Welcome {student.Name}");
            Console.WriteLine("Enrolled courses with CourseID ");
            foreach (var item in student.StudentCourses)
            {
                Course course = context.Courses.Where(x => x.Id == item.CourseId).FirstOrDefault();
                
                Console.WriteLine($"{item.CourseId}.{course.CourseName}");
         
            }
          
           
            plusAttendence attendence = new plusAttendence();
            attendence.GiveAttendence(student.Id, student.Name, context);






        }
    }
}
