int x = 0, i;//ac
string srt1 = Console.ReadLine();
string srt2 = Console.ReadLine();

string lowerstr1 = srt1.ToLower();
string lowerstr2 = srt2.ToLower();


for (i = 0; i < srt1.Length; i++)
{
    if (lowerstr1[i] == lowerstr2[i])
    {
        x = 0;
    }
    else if (lowerstr1[i] < lowerstr2[i])
    {
        x = -1;
        break;
    }
    else if (lowerstr1[i] > lowerstr2[i])
    {
        x = 1;
        break;
    }
}

Console.WriteLine(x);