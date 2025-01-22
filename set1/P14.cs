using System;

class Program
{
    static bool EstePalindrom(int n)
    {
        if (n < 0) return false;
        int original = n;
        int invers = 0;
        while (n > 0)
        {
            int cif = n % 10;
            invers = invers * 10 + cif;
            n /= 10;
        }
        return original == invers;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (EstePalindrom(n))
        {
            Console.WriteLine($"{n} este un palindrom.");
        }
        else
        {
            Console.WriteLine($"{n} nu este un palindrom.");
        }
    }
}
