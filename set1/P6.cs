namespace set1
{
    internal class Program
    {
      static bool Triunghi(int a , int b,int c)
        {
            return a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
        }
        static void Main(string[] args)
        {
        int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (Triunghi(a, b, c))
            {
                Console.WriteLine("se poate forma triunghi");
            }
            else
            {
                Console.WriteLine("nu se poate");
            }
        }
    }
}
