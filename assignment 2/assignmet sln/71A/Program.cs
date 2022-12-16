string s;
s = Console.ReadLine();
char[] a = s.ToCharArray();
a[0] = char.ToUpper(a[0]);

Console.WriteLine(new string(a)); 