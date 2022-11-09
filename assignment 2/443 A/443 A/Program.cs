String str = Console.ReadLine();
char[] spearator = {'{',',','}'};
String[] strlist = str.Split(spearator);
Array.Sort(strlist);

int cnt = 0;

for (int i = 0; i < (strlist.Length-1); i++)
{
    if (strlist[i] != strlist[i + 1])
    {
        cnt++;
    }
 


}
Console.WriteLine(cnt);

