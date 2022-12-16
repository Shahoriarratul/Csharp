int k, n, w;

string[] stringArray = Console.ReadLine().Split(' ');
k = int.Parse(stringArray[0]);
n = int.Parse(stringArray[1]);
w = int.Parse(stringArray[2]);

int sum = 0;
for (int i = 1; i <= w; i++)
{
    sum += i;
}
int d = (sum * k) - n;
if (d < 0)
    Console.WriteLine("0"); 
else
    Console.WriteLine(d); 