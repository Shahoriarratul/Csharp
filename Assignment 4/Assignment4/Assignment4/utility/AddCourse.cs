﻿using Assignment4.Activity;
using Assignment4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.utility
{
    public class AddCourse
    {
        public void plusCourse(TrainingDbContext context)
        {
            Console.Write("enter Course Name :");
            string CourseName = Console.ReadLine();
            Console.Write("enter Course Fees :");
            int Fees = Convert.ToInt32(Console.ReadLine());

            Course newCourse = new Course();
            newCourse.CourseName = CourseName;
            newCourse.fees = Fees;
            newCourse.FirstClssDay = "";
            newCourse.LastClssDay = "";
            newCourse.FirstClssTime = "";
            newCourse.LastClassTime = "";
            newCourse.Totalclass = 0;
            newCourse.TeacherID = 0; 
            context.Add(newCourse);
            context.SaveChanges();
            Console.Write("Course added \n");
            AdminActivity adminActivity = new AdminActivity();


        }
    }
}
