using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (IsMade(n))
        {
            Console.WriteLine($"este format din două cifre care se pot repeta.");
        }
        else
        {
            Console.WriteLine($"NU este format din două cifre care se pot repeta.");
        }
    }

    static bool IsMade(int n)
    {
        string nr = n.ToString();
        char fd = nr[0];
        char sd = '\0';

        foreach (char digit in nr)
        {
            if (digit != fd)
            {
                if (sd == '\0')
                {
                    sd = digit;
                }
                else if (digit != sd)
                {
                    return false;
                }
            }
        }
        return true;
    }
}
