int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);//ac
int n = nk[0];
int k = nk[1];
int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int count = 0;
for (int i = 0; i < n; i++)
{
    if (k <= 5 - arr[i])
        count++;
}
Console.WriteLine(count / 3);