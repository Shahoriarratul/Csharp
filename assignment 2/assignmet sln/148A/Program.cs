int  count = 0;//ac
int k = Convert.ToInt32(Console.ReadLine());
int l = Convert.ToInt32(Console.ReadLine());

int m = Convert.ToInt32(Console.ReadLine());

int n = Convert.ToInt32(Console.ReadLine());

int d = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= d; i++)
{
    if (i % k == 0 || i % l == 0 || i % m == 0 || i % n == 0)
    {
        count++;
    }
}
Console.WriteLine(count); 