int t;//ac
long n, sum1, sum2;
t = Convert.ToInt32(Console.ReadLine());
while(t!=0)
{
    t--;
    sum1 = sum2 = 0;
     n = Convert.ToInt32(Console.ReadLine());

    if (n % 4 != 0)
    {
        Console.WriteLine("NO"); 
    }
    else
    {
        Console.WriteLine("YES");

        for (int i = 2; i <= n; i += 2)
        {
            Console.Write(i+" ");
            sum1 += i;
        }
        for (int i = 1; i < n - 2; i += 2)
        {
            Console.Write(i + " ");
            sum2 += i;
        }
        Console.Write(sum1 - sum2+ "\n");
    }
}
