int n;//c
 n = Convert.ToInt32(Console.ReadLine());
float sum = 0;
int[] arr = new int[n];
string[] stringArray = Console.ReadLine().Split(' ');

for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(stringArray[i]);
    sum = sum + arr[i];
}
Console.WriteLine(sum / n); 
