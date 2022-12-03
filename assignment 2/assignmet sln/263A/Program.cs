int[,] arr = new int[5, 5];//ac
int x = 0, y = 0, i = 0, j = 0;

for (i = 0; i < 5; i++)
{
    int[] temp = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    for (j = 0; j < 5; j++)
    {
        arr[i, j] = temp[j];
        if (temp[j] == 1)
        {
            x = i;
            y = j;
        }
    }
}
x++;
y++;
Console.WriteLine(Math.Abs(3 - x) + Math.Abs(3 - y));