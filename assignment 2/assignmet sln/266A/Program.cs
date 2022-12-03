string b;//ac
int a, c=0;
  a = Convert.ToInt32(Console.ReadLine()); 
  b = Console.ReadLine(); 

    for (int i = 0; i < a-1; i++)
    {
        if (b[i] == b[i + 1])
        {
            c++;
        }
    }
    Console.WriteLine(c); 