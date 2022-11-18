int t; //ac
t = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[t];

for (int i = 0; i < t; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());

    if (arr[i] == 1 || arr[i] == 2)
    {
        Console.WriteLine("0"); 
    }
    else
    {
        Console.WriteLine((arr[i] - 1) / 2); 
    }
}