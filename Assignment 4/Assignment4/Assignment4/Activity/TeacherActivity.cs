﻿using Assignment4.Entities;
using Assignment4.utility;
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
        

            Teacher teacher = context.Teachers.Where(x => x.id == id).FirstOrDefault();
            
            Console.WriteLine($"Welcome {teacher.Name}");
            
            Console.WriteLine("Assigned courses with CourseID");
            
            foreach (var item in course)
            {
              

                Console.WriteLine($"{item.Id}.{item.CourseName}");

            }
            Console.WriteLine("All courses with CourseID");
            List<Course> courseList = context.Courses.ToList();

            foreach (var item in courseList)
            {


                Console.WriteLine($"{item.Id}.{item.CourseName}");

            }

            Report report = new Report();
            report.ShowReport(context);



        }
    }
}
