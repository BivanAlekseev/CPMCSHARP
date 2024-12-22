using System;

class Program
{
    static void Main(string[] args)
    {
        // Заголовки таблицы
        Console.WriteLine("Тип данных | Размер (байт) | Минимум | Максимум");

        // Данные типов и их характеристики
        Console.WriteLine("sbyte      | {0, -12} | {1, -7} | {2, -7}", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("byte       | {0, -12} | {1, -7} | {2, -7}", sizeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine("short      | {0, -12} | {1, -7} | {2, -7}", sizeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine("ushort     | {0, -12} | {1, -7} | {2, -7}", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("int        | {0, -12} | {1, -7} | {2, -7}", sizeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine("uint       | {0, -12} | {1, -7} | {2, -7}", sizeof(uint), uint.MinValue, uint.MaxValue);
        Console.WriteLine("long       | {0, -12} | {1, -7} | {2, -7}", sizeof(long), long.MinValue, long.MaxValue);
        Console.WriteLine("ulong      | {0, -12} | {1, -7} | {2, -7}", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("float      | {0, -12} | {1, -7} | {2, -7}", sizeof(float), float.MinValue, float.MaxValue);
        Console.WriteLine("double     | {0, -12} | {1, -7} | {2, -7}", sizeof(double), double.MinValue, double.MaxValue);
        Console.WriteLine("decimal    | {0, -12} | {1, -7} | {2, -7}", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
    }
}
