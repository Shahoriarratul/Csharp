int n, ans = 0;//ac
int[] a = { 100, 20, 10, 5, 1 };
n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < 5; i++)
{
    ans += n / a[i];
    n = n % a[i];
}
Console.WriteLine (ans);