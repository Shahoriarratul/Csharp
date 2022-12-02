int[] a = new int[55];

int t;
t = Convert.ToInt32(Console.ReadLine());
    while (t!=0)
    {
        int n;
        n = Convert.ToInt32(Console.ReadLine());
       string[] stringArray = Console.ReadLine().Split(' ');

    for (int i = 0; i <= n-1; i++)
        {
       
        a[i] = int.Parse(stringArray[i]);
    }
       Array.Sort(a);
    int[] s =new int[a.Length];
    for (int i = 0; i < a.Length-1; i++)
    {
        s[i + 1] = a[i];
    }



        int flag = 1;

        for (int i = 1; i <= n-1; i++)
        {
            if (s[i] > s[i - 1] + 1)
            {
            Console.WriteLine("NO");  
                flag = 0;
                break;
            }
        }
    if (flag == 1)
    { Console.WriteLine("YES"); }
    t--;   
}

