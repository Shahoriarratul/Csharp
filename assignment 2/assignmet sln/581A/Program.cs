int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int mini = arr.Min();
Console.WriteLine(mini + " " + (arr[0] + arr[1] - 2 * mini) / 2);
