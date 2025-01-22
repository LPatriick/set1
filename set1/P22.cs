using System;

class Program
{
    static void Main()
    {
        int lower = 1;
        int upper = 1024;
        int mid;
        string response;

        Console.WriteLine("Ghiceste un numar intre 1 si 1024.");
        Console.WriteLine("Raspunde cu 'da' sau 'nu' la fiecare intrebare.");

        while (lower <= upper)
        {
            mid = (lower + upper) / 2;

            Console.WriteLine($"Numarul este mai mare sau egal decat {mid}? (da/nu)");
            response = Console.ReadLine().ToLower();

            if (response == "da")
            {
                lowerBound = mid;
            }
            else if (response == "nu")
            {
                upperBound = mid - 1;
            }
            else
            {
                Console.WriteLine("Raspunde cu 'da' sau 'nu'.");
                continue;
            }

            if (lower == upper)
            {
                Console.WriteLine($"Numarul este {lowerBound}.");
                break;
            }
        }
    }
}
