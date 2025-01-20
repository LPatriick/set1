namespace set1
{
    internal class Program
    {

            static void Main(string[] args)
        {
     int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                int cif = n % 10;
                Console.Write(cif);
                n /= 10;
            }
        }
    }
}
