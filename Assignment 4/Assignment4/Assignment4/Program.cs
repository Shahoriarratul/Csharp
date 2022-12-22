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
            Teacher T1 =context.Teachers.Where(x => x.Name == U1.Name).FirstOrDefault();

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
    }

}
else
{
    Console.WriteLine("wrong username try again");
}


