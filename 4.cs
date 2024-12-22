using System;
using System.Text;

class Program
{
    static string GetPrimeFactors(int number)
    {
        StringBuilder result = new StringBuilder();
        int divisor = 2;

        while (number > 1)
        {
            if (number % divisor == 0)
            {
                result.Append(divisor);
                result.Append(" ");
                number /= divisor;
            }
            else
            {
                divisor++;
            }
        }

        return result.ToString().Trim();
    }

    static void Main(string[] args)
    {
        Console.WriteLine();
        int number = int.Parse(Console.ReadLine());

        string primeFactors = GetPrimeFactors(number);
        Console.WriteLine($"Простые множители числа {number}: {primeFactors}");
    }
}
