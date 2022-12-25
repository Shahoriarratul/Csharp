
using System.Globalization;
CultureInfo provider = CultureInfo.InvariantCulture;

Console.WriteLine("Hello, World!");
string day = "01/11/2022";
string format1 = "dd/MM/yyyy";


DateTime result1 = DateTime.ParseExact(day, format1, provider);

string COM1 = result1.ToString("ddd", provider);

Console.WriteLine(COM1);





string COM2 =Console.ReadLine();

Console.WriteLine(COM2);

int i=0;
while (i < 10)
{

    COM1 = result1.ToString("ddd", provider);
    if (COM2==COM1)
    {
        
        
        Console.Write ($"{result1.ToString("dd/MM/yyyy ddd", provider)} ||");

        i++;
    }

     result1 = result1.AddDays(1);


}


