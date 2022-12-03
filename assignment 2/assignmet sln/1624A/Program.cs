namespace _1624A//ac
{
    internal class Program
    {
        void solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int maxi = arr.Max();
            int mini = arr.Min();
            Console.WriteLine(maxi - mini);
        }
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            while (test-- > 0)
            {
                Program program = new Program();
                program.solve();
            }
        }
    }
}