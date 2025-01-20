namespace set1
{
    internal class Program
    {
     static void Div(int n)
        {
            for (int d = 1; d <= Math.Sqrt(n); d++)
            {
                if (n % d == 0)
                {
                    Console.WriteLine(d);
                    if (d != n / d)
                    {
                        Console.WriteLine((n / d) + " ");
                    }
                }
            }        
                
        }
        static void Main(string[] args)
        {
     int n = int.Parse(Console.ReadLine());
          Div(n);
        }
    }
}
