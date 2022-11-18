int n;//ac
n= Convert.ToInt32(Console.ReadLine()); 
int a, b;
int sum = 0, k = 0;
for (int i = 0; i < n; i++)
{
    string[] stringArray = Console.ReadLine().Split(' ');

    a = int.Parse(stringArray[0]);
    b = int.Parse(stringArray[1]);

    sum = (a + k) - b;
    if (sum < 0)
        k = 0;
    else
        k = sum;
}
Console.WriteLine(sum); 