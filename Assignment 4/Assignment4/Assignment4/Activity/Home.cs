using Assignment4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment4;
using Assignment4.Activity;
using Assignment4.utility;

namespace Assignment4.Activity
{
    public class Home
    {
        public Home()
        {

            TrainingDbContext context = new TrainingDbContext();
      
            Console.Write("Enter username :");
            string username = Console.ReadLine();


            List<User> user = context.Users.ToList();

            User U1 = context.Users.Where(x => x.UserName == username).FirstOrDefault();

            if (U1 != null)
            {
                Console.Write("Enter password :");
                string password = Console.ReadLine();
                if (password == U1.password)
                {
                    if (U1.userType == 0)
                    {
                        Console.WriteLine("\n welcome admin");
                        AdminActivity adminActivity = new AdminActivity();
                    }
                    if (U1.userType == 1)
                    {
                        Teacher T1 = context.Teachers.Where(x => x.Name == U1.Name).FirstOrDefault();

                        TeacherActivity teacherActivity = new TeacherActivity(T1.id);
                    }
                    if (U1.userType == 2)
                    {
                        Student S1 = context.Students.Where(x => x.Name == U1.Name).FirstOrDefault();


                        StudentActivity studentActivity = new StudentActivity(S1.Id);
                    }

                }
                else
                {
                    Console.WriteLine("wrong password try again");
                    Home home = new Home();
                }

            }
            else
            {
                Console.WriteLine("wrong username try again");
                Home home = new Home();
            }

        }
    }
}
