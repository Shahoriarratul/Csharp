string name = Console.ReadLine();
Dictionary<char, byte> d = new();

int count = 0;
for (int i = 0; i < name.Length; i++)
{
    if (!d.ContainsKey(name[i]))
    {
        d.Add(name[i], 1);
        count = count + 1;
    }
}

Console.WriteLine(count % 2 == 0 ? "CHAT WITH HER!" : "IGNORE HIM!");