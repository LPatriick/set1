using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Descompunerea este: {PrimeFac(n)}");
    }

    static string PrimeFac(int n)
    {
        int fact = 2;
        string result = "";
        while (n > 1)
        {
            int p = 0;
            while (n % fact == 0)
            {
                p++;
                n /= fact;
            }
            if (p > 0)
            {
                result += (result == "" ? "" : " x ") + $"{fact}^{p}";
            }
            fact++;
        }
        return result;
    }
}
