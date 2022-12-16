int n = Convert.ToInt32(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int odd = 0, even = 0;
for (int i = 0; i < n; i++)
{
    if (arr[i] % 2 != 0)
        odd++;
    else
        even++;

    if (even > 1 || odd > 1)
    {
        break;
    }
}
if (odd > even)
{
    for (int i = 0; i < n; i++)
    {
        if (arr[i] % 2 == 0)
            Console.WriteLine(i + 1);
    }
}
else
{
    for (int i = 0; i < n; i++)
    {
        if (arr[i] % 2 != 0)
            Console.WriteLine(i + 1);
    }
}
