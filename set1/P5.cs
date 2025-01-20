namespace set1
{
    internal class Program
    {
        static int Cifk(int nr, int k)
        {
            for (int i = 1; i < k; i++)
            {
                nr /= 10;
            }
            if (nr == 0)
            {
                return -1;
            }
            return Math.Abs(nr % 10);
        }
        static void Main(string[] args)
        {
         int nr = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int c = Cifk(nr, k);
            if (c == -1)
            {
                Console.WriteLine("Nu are destule cifre");
            }
            else
            {
                Console.WriteLine($"Cifra nr {k} este {c}");
            }
        }
    }
}
