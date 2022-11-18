using System;

int count = 0;
string[] s = Console.ReadLine().Split('{',',','}');

Array.Sort(s);


for (int i = 0; i < s.Length-1; i++)
{

        Console.WriteLine(s[i]);

    if (s[i] == "{" || s[i] == "}" || s[i] == ",")
    {
        continue;
    }
    else
    {
        if (s[i] != s[i + 1])
        {
            count++;
        }
    }
}
Console.WriteLine(count - 1);