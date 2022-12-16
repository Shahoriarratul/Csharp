string s;
 s= Console.ReadLine();
int count = 0;
for (int i = 0; i < s.Length; i++)
{
    if (s[i] == '4' || s[i] == '7')
    {
        count++;
    }
}
if (count == 4 || count == 7)
{
    Console.WriteLine("YES"); 
}
else
{
    Console.WriteLine("NO"); 
}