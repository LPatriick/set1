using System;

class Program
{
    static void Main(string[] args)
    {

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        if (a > b) (a, b) = (b, a);
        if (b > c) (b, c) = (c, b);
        if (c > d) (c, d) = (d, c);
        if (d > e) (d, e) = (e, d);

        if (a > b) (a, b) = (b, a);
        if (b > c) (b, c) = (c, b);
        if (c > d) (c, d) = (d, c);

        if (a > b) (a, b) = (b, a);
        if (b > c) (b, c) = (c, b);

        if (a > b) (a, b) = (b, a);

        Console.WriteLine($"Ordinea crescatoare este: {a}, {b}, {c}, {d}, {e}");
    }
}
