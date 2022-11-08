String str = Console.ReadLine();
char[] spearator = { '{',',','}'};
String[] strlist = str.Split(spearator);
int cnt = 0;

for (int i = 1; i <(strlist.Length-1); i++)
{
    cnt++;
    for (int j = 1; j <(strlist.Length - 1); j++)
    {
        if (i!=j && strlist[i] == strlist[j])
        {

           
        }
        else
        {
            cnt++;
        }
       
    }
    Console.WriteLine(cnt);
}
Console.WriteLine(cnt);