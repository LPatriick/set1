namespace set1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (n % k == 0)
            {
                Console.WriteLine($"{n} se div cu {k}");
            }
            else
            {
                Console.WriteLine($"{n} nu se div cu {k}");
            }
        }
    }
}
