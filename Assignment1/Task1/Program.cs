Console.WriteLine("enter matix size");
int s = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[s, s];
int collSum = 0;
int rowSum = 0;

for (int i=0; i < s; i++)
{
    for (int j=0;j<s;j++)
    {
        Console.WriteLine("enter " + i + " row " + j + " collum ");
        arr[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}
for(int i=0; i < s; i++)
{
    rowSum = 0;
    for(int j=0; j<s; j++)
    {

        rowSum = rowSum + arr[i, j];
    }
    Console.WriteLine(i + " Number row sum " + rowSum);
}
for (int i = 0; i < s; i++)
{
    collSum = 0;
    for (int j = 0; j < s; j++)
    {

        collSum = collSum + arr[j, i];
    }
    Console.WriteLine(i + " Number collum sum " + collSum);
}
int k = 0;
int l = 0; ;
int crossSum = 0;
while ( k < s &&  l < s)
    {
    
    crossSum=crossSum+ arr[k, l];
    k++;
    l++;

}
Console.WriteLine("Left cross sum " + crossSum);

 k = 0;
 l = s-1; ;
int crossSum2 = 0;
while (k < s && l >= 0)
{

    crossSum2 =  arr[k, l]+crossSum2 ;
    k++;
    l=l-1;
 

}
Console.WriteLine("Right cross sum " + crossSum2);




