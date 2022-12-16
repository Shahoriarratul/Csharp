int n = Convert.ToInt32(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == 1)
    {
        Console.WriteLine("Hard");
        return;
    }
    else
        count++;
}
if (count == n)
    Console.WriteLine("Easy");