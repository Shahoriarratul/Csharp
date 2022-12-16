int x, a, b, c, count = 0;
x = Convert.ToInt32(Console.ReadLine()) ;
for (int i = 0; i < x; i++)
{
    string[] stringArray = Console.ReadLine().Split(' ');
    a = int.Parse(stringArray[0]);
    b = int.Parse(stringArray[1]);
    c = int.Parse(stringArray[2]);


    if (a + b + c >= 2)
    {
        count++;
    }
}
Console.WriteLine(count); 