int t =Convert.ToInt32(Console.ReadLine());//ac
for (int i = 0; i < t; i++)
{
    long a, b;
    string[] stringArray = Console.ReadLine().Split(' ');
    a = int.Parse(stringArray[0]);
    b = int.Parse(stringArray[1]);
    if (a % b == 0)
        Console.WriteLine("0");
    else
        Console.WriteLine(b - (a % b)); 
}