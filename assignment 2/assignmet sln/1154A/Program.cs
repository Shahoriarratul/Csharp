int[] a= new int[4]; //ac

string[] stringArray = Console.ReadLine().Split(' ');

for (int i = 0; i < 4; i++)
{
    a[i] = int.Parse(stringArray[i]); ;

}
Array.Sort(a);

int c = a[3] - a[0];
int b = a[2] - c;
int ar = a[3] - (b + c);
 Console.WriteLine(ar+" "+b +" "+c);
