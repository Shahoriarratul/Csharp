int a; //ac
a = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[a];
int ma = 0, mi = 101, maxi = 0,  mini = 0;

string[] stringArray = Console.ReadLine().Split(' ');

for (int i = 0; i < a; i++)
{

    arr[i] = int.Parse(stringArray[i]);
    if (arr[i] > ma)
    {
        ma = arr[i];
        maxi = i;
    }
    if (arr[i] <= mi)
    {
        mi = arr[i];
        mini = i;
    }
}
if (maxi > mini)
{
    mini++;
}
Console.WriteLine(maxi + (a - 1) - mini); 