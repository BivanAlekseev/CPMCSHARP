using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class NegativeInteger
    {
        private int value;

        public NegativeInteger(int value)
        {
            this.value = value;
            Console.WriteLine("Объект NegativeInteger создан.");
        }

        public NegativeInteger(NegativeInteger obj)
        {
            this.value = obj.value;
            Console.WriteLine("Объект NegativeInteger скопирован.");
        }

        public int GetValue()
        {
            return value;
        }

        public void SetValue(int value)
        {
            if (value < 0)
            {
                this.value = value;
            }
            else
            {
                Console.WriteLine("Значение должно быть отрицательным.");
            }
        }

        public void PrintValue()
        {
            Console.WriteLine($"Значение: {value}");
        }

        public int CompareTo(NegativeInteger other)
        {
            return this.value.CompareTo(other.value);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            NegativeInteger obj1 = new NegativeInteger(-10);
            obj1.PrintValue();

            obj1.SetValue(-20);
            obj1.PrintValue();

            int value = obj1.GetValue();
            Console.WriteLine($"Полученное значение: {value}");

            NegativeInteger obj2 = new NegativeInteger(-30);
            obj2.PrintValue();

            int comparisonResult = obj1.CompareTo(obj2);
            if (comparisonResult > 0)
            {
                Console.WriteLine("obj1 больше obj2");
            }
            else if (comparisonResult < 0)
            {
                Console.WriteLine("obj1 меньше obj2");
            }
            else
            {
                Console.WriteLine("obj1 равен obj2");
            }
        }
    }

}
