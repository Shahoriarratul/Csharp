
int tc = Convert.ToInt32(Console.ReadLine());//ac

string s;

while (tc!=0)
    {
    s = Console.ReadLine();
   

    Console.Write(s[0]); 

    for (int i = 1; i < s.Length; i += 2)
    {
        Console.Write(s[i]);
    }
    Console.WriteLine();
    tc--;
      
    
}
   

