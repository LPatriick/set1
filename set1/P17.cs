using System;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int gcd = GCD(a, b);
        int lcm = (a * b) / gcd;
        Console.WriteLine($"Cel mai mare divizor comun este: {gcd}");
        Console.WriteLine($"Cel mai mic multiplu comun este: {lcm}");
    }

    static int GCD(int x, int y)
    {
        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }
        return x;
    }
}
