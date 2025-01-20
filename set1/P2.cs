namespace set1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d, x1, x2, x;
            if (a == 0)
            {
                // Tratarea cazului a = 0 (ecuație de gradul I)
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("infinitate de sol");
                    }
                    else
                    {
                        Console.WriteLine("nu are sol");
                    }
                }
                else
                {
                    x = -c / b;
                    Console.WriteLine(x);
                }
            }
            else
            {
                d = b * b - 4 * a * c;

                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / 2 * a;
                    x2 = (-b - Math.Sqrt(d)) / 2 * a;
                    Console.WriteLine(x1 + " " + x2);
                }
                else if (d == 0)
                {
                    x = -b / 2 * a;
                    Console.WriteLine(x);
                }
                else
                {
                    double rp = -b / (2 * a);
                    double ip = Math.Sqrt(-d) / (2 * a);
                    Console.WriteLine($"x1 = {rp} + {ip}i, x2 = {rp} - {ip}i");
                }
            }
        }
    }
}
