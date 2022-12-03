int n = Convert.ToInt32(Console.ReadLine());//ac
int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int h = 0, un = 0;
for (int i = 0; i < n; i++)
{
    if (arr[i] != -1)
        h += arr[i];
    else if (arr[i] == -1)
    {
        if (h != 0)
            h--;
        else if (h == 0)
            un++;
    }
}
Console.WriteLine(un);