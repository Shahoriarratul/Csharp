int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int n = arr[0];
int k = arr[1];
while (k-- > 0)
{
    if (n % 10 == 0)
        n /= 10;
    else
        n--;
}
Console.WriteLine(n);