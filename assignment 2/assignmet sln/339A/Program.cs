int[] arr = Array.ConvertAll(Console.ReadLine().Split('+'), int.Parse);//ac
Array.Sort(arr);
Console.Write(arr[0]);
for (int i = 1; i < arr.Length; i++)
    Console.Write("+" + arr[i]);
Console.WriteLine();