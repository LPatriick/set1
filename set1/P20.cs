using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string result = FractionToDecimal(m, n);
        Console.WriteLine($"Reprezentarea zecimală este: {result}");
    }

    static string FractionToDecimal(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            return "Eroare:NU se poate imparti la 0.";
        }

        int integralPart = numerator / denominator;
        int remainder = numerator % denominator;

        if (remainder == 0)
        {
            return integralPart.ToString();
        }

        string decimalPart = "";
        Dictionary<int, int> remainderPositions = new Dictionary<int, int>();
        int position = 0;
        bool isRepeating = false;
        int repeatingStart = -1;

        while (remainder != 0)
        {
            if (remainderPositions.ContainsKey(remainder))
            {
                isRepeating = true;
                repeatingStart = remainderPositions[remainder];
                break;
            }

            remainderPositions[remainder] = position;
            remainder *= 10;
            int digit = remainder / denominator;
            decimalPart += digit;
            remainder %= denominator;
            position++;
        }

        if (isRepeating)
        {
            return $"{integralPart}.{decimalPart.Substring(0, repeatingStart)}({decimalPart.Substring(repeatingStart)})";
        }

        return $"{integralPart}.{decimalPart}";
    }
}
