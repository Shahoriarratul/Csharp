Console.WriteLine("Enter how many inputs you want?");
int s = Convert.ToInt32(Console.ReadLine());
int a = 0, b = 0, c = 0,j=0,temp=0;
if (s < 3)
{
    Console.WriteLine("you must have more than 3 input");
}
else
{
   

    for (int i = 0; i < s; i++)
    {
        j = i + 1;
        Console.WriteLine("enter " + j + " Number input ");
        temp = Convert.ToInt32(Console.ReadLine());
        if (i <= 2)
        {
          

            if (i == 0)
            {
                a = temp;
            }

            if (i == 1 && temp < a)
            {
                b = temp;
            }
            else if (i == 1 && temp > a)
            {
                b = a;
                a = temp;
            }


            if (i == 2 && temp < b)
            {
                c = temp;
            }
            else if (i == 2 && temp > b && temp < a)
            {
                c = b;
                b = temp;
            }
            else if (i == 2 && temp > a)
            {
                c = b;
                b = a;
                a = temp;
            }

        }
        else
        {
            if(temp>a)
            {
                c = b;
                b = a;
                a = temp;
            }
            else if(temp<a && temp > b)
            {
                c = b;
                b = temp;

            }
            else if(temp>c && temp < b)
            {
                c = temp;
            }

        }








       
        



    }

   
}
Console.WriteLine("third largets number is " + c);
