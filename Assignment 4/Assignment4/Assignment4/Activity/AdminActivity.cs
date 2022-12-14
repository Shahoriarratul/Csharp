using Assignment4.Entities;
using Assignment4.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Activity
{
    public class AdminActivity
    {   
     
        public AdminActivity()
        {

            TrainingDbContext context = new TrainingDbContext();

            Console.WriteLine("welcome admin");
            Console.WriteLine("press 1 to add Teacher");
            Console.WriteLine("press 2 to add student");
            Console.WriteLine("press 3 to create courses ");
            Console.WriteLine("press 4 to assign a teacher in a course ");
            Console.WriteLine("press 5 assign students in a course ");

            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
                PlusUser("Teacher",
            context);
            if (input == 2)
                PlusUser("Student",
            context);
            if (input == 3)
                PlusCourse(context);







        }
        public void PlusUser(string type, TrainingDbContext context)
        {
            Console.Write("enter Name :");
            string Name = Console.ReadLine();
            Console.Write("enter username :");
            string username = Console.ReadLine();
            Console.Write("enter password :");
            string password = Console.ReadLine();
          
            User newUser = new User();
            newUser.Name = Name;
            newUser.UserName = username;
            newUser.password = password;

            if (type == "Teacher")
                newUser.userType = 1;
            else if (type == "Student")
                newUser.userType= 2;
            context.Add(newUser);
            context.SaveChanges();

            Console.Write("user added");



        }
        public void PlusCourse(TrainingDbContext context)
        {
            Console.Write("enter Course Name");
            string CourseName = Console.ReadLine();
            Console.Write("enter Course Fees");
            int Fees = Convert.ToInt32(Console.ReadLine());

            Course newCourse = new Course();
            newCourse.CourseName = CourseName;
            newCourse.fees = Fees;
            context.Add(newCourse);
            context.SaveChanges();
            Console.Write("Course added");


        }

    }
}
