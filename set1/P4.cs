namespace set1
{
    internal class Program
    {
        static bool AnBis(int y)
        {
            return ((y % 4 == 0) && (y % 100 != 0) || (y % 400 == 0));
        }
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            if (AnBis(y))
            {
                Console.WriteLine($"{y} este an bisect");
            }
            else
            {
                Console.WriteLine($"{y} nu este bisect");
            }

        }
    }
}
