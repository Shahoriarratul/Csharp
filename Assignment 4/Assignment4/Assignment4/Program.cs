using Assignment4;
using Assignment4.Activity;
using Assignment4.Entities;
using Assignment4.utility;

TrainingDbContext context = new TrainingDbContext();
Console.WriteLine("welcome to attendence system");
Console.Write("enter username :");
string username = Console.ReadLine();


List<User> user = context.Users.ToList();

User U1 = context.Users.Where(x => x.UserName == username).FirstOrDefault();

if(U1 != null)
{
    Console.Write("enter password :");
    string password = Console.ReadLine();
    if (password == U1.password)
    {
        if(U1.userType==0)
        {
            Console.WriteLine("\n welcome admin");
            AdminActivity adminActivity = new AdminActivity();
        }
        if (U1.userType == 1)
        {
            Console.WriteLine("\n welcome Teacher");
            TeacherActivity teacherActivity = new TeacherActivity();
        }
        if (U1.userType == 2)
        {
            Console.WriteLine("\n welcome Student");
            StudentActivity studentActivity = new StudentActivity();
        }

    }
    else
    {
        Console.WriteLine("wrong password try again");
    }

}
else
{
    Console.WriteLine("wrong username try again");
}


