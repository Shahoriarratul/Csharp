

int y = Add(12, 13, 10, 15, 56);

// Displaying result
Console.WriteLine(y);


 int Add(params int[] ListNumbers)
{
    int total = 0;

    // foreach loop
    foreach (int i in ListNumbers)
    {
        total += i;
    }
    return total;
}