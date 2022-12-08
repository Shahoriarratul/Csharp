int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));//ac
int n = arr[0];
int m = arr[1];

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= m; j++)
    {
        if (i % 4 == 0)
        {
            if (j == 1)
                Console.Write('#');
            else
                Console.Write('.');
        }
        else if (i % 4 == 2)
        {
            if (j == m)
                Console.Write('#');
            else
                Console.Write('.');
        }
        else
            Console.Write('#');
    }
    Console.WriteLine();
}