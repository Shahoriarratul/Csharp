int n = Convert.ToInt32(Console.ReadLine());//ac
int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int a = arr1[0];
int b = arr2[0];
int[] arr = new int[a + b];

for (int i = 0; i < a; i++)
    arr[i] = arr1[i + 1];
for (int i = a; i < a + b; i++)
    arr[i] = arr2[i - (a - 1)];

arr = arr.Distinct().ToArray();

if (arr.Length == n)
    Console.WriteLine("I become the guy.");
else
    Console.WriteLine("Oh, my keyboard!");