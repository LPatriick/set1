using System;

class Program
{
    static void Main(string[] args)
    {
        string n = Console.ReadLine();
        
        if (IsPalindrome(n))
        {
            Console.WriteLine($"{n} este palindrom.");
        }
        else
        {
            Console.WriteLine($"{n} nu este palindrom.");
        }
    }

    static bool IsPalindrome(string nr)
    {
        int length = number.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (nr[i] != nr[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
