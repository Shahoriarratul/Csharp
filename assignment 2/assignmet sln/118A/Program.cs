string s = Console.ReadLine();
s = s.ToLower();
string temp = "";
for (int i = 0; i < s.Length; i++)
{
    if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'y')
        continue;
    else
    {
        temp += '.';
        temp += s[i];
    }
}
Console.WriteLine((string)temp.ToLower());