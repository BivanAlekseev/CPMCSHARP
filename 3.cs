using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("первое число");
            int firstNumber = int.Parse(Console.ReadLine());


            Console.WriteLine("второе число");
            int secondNumber = int.Parse(Console.ReadLine());


            if (secondNumber == 0)
            {
                throw new DivideByZeroException("Нельзя");
            }

            int result = firstNumber / secondNumber;
            Console.WriteLine($"Результат деления: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("введены некорректные данные");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла неизвестная ошибка: {ex.Message}");
        }
    }
}
