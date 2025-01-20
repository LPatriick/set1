namespace set1
{
    internal class Program
    {
        static bool Prim(int n)
        {
            if (n >= 1)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return true;
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
            static void Main(string[] args)
        {
     int n = int.Parse(Console.ReadLine());
            if (Prim(n))
            {
                Console.WriteLine("prim");
            }
            else
            {
                Console.WriteLine("neprim");
            }
        }
    }
}
