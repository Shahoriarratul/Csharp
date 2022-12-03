int y = Convert.ToInt32(Console.ReadLine());//ac
int f, s, t, q;
while (true)
{
    y += 1;
    f = y / 1000;
    s = y / 100 % 10;
    t = y / 10 % 10;
    q = y % 10;
    if (f != s && f != t && f != q && s != t && s != q && t != q)
        break;
}
Console.Write(f);
Console.Write(s);
Console.Write(t);
Console.Write(q);