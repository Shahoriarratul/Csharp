int n = Convert.ToInt32(Console.ReadLine());
int[] arr = { 4, 7, 47, 74, 44, 444, 447, 474, 744, 774, 747, 477, 777, 77 };
bool f = false;
for (int i = 0; i < 12; i++)
{
    if (n % arr[i] == 0)
        f = true;
}
if (f == true)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");