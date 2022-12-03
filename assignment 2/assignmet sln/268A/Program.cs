int a, count = 0;//ac
 a= Convert.ToInt32(Console.ReadLine());
int[] x = new int[a];
int[] y = new int[a];


for (int i = 0; i < a; i++)
{
    string[] stringArray = Console.ReadLine().Split(' ');
 
        x[i] = int.Parse(stringArray[0]);
    y[i] = int.Parse(stringArray[1]);
}
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < a; j++)
    {
        if (x[i] == y[j])
        {
            count++;
        }
    }
}
Console.WriteLine(count); 