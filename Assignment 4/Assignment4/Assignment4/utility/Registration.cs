using Assignment4.Activity;
using Assignment4.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment4.utility
{
    public class Registration
    {
        public void plusReg(string type ,TrainingDbContext context)
        {
            if (type == "Teacher")
            {

                Console.Write("Enter Teacher Name :");
                string TeacherName = Console.ReadLine();
                Teacher T1 = context.Teachers.Where(x => x.Name == TeacherName).FirstOrDefault();
                if(T1 != null)
                {
                    Console.Write("Enter course Name :");
                    string CourseName = Console.ReadLine();
                    
                    Course C1 = context.Courses.Where(x => x.CourseName == CourseName).FirstOrDefault();
                    if(C1 != null)
                    {
                        C1.TeacherID = T1.id;
                        context.SaveChanges();
                        AdminActivity adminActivity = new AdminActivity();
                    }
                    else Console.WriteLine("course does not exist");
                   
                }
                else Console.WriteLine("There is no teacher by this name");



            }

            else if (type == "Student")
            {

                Console.Write("Enter Student Name :");
                string StudentName = Console.ReadLine();
                Student S1 = context.Students.Where(x => x.Name == StudentName).FirstOrDefault();
                if (S1 != null)
                {
                    Console.Write("Enter course Name :");
                    string CourseName = Console.ReadLine();

                    Course C1 = context.Courses.Where(x => x.CourseName == CourseName).FirstOrDefault();
                    if (C1 != null)
                    {
                        CourseRegistration Registration = new CourseRegistration();
                        Registration.StudentId = S1.Id;
                        Registration.CourseId = C1.Id;
                        context.Add(Registration);
                        context.SaveChanges();
                    }
                    else Console.WriteLine("There is no course by this name");

                }
                else Console.WriteLine("There is no student by this name");


            }
        }
    }
}
