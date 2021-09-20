using System;
using System.Threading.Channels;

namespace Task07
{
    class Program
    {
        public static void GetParts(double x)
        {
            Console.WriteLine("Целая часть: " + (int)x);
            Console.WriteLine("Дробная часть: " + (x - (int)x));
        }

        public static void SqrtAndPow(double x)
        {
            if (x >= 0)
            {
                Console.WriteLine("Корень: " + Math.Sqrt(x));
            }
            else
            {
                Console.WriteLine("Корень вычислить нельзя");
            }

            Console.WriteLine("Квадрат: " + Math.Pow(x, 2));
        }
        
        static void Main(string[] args)
        {
            bool flag;
            double x;
            do
            {
                do
                {
                    Console.WriteLine("Введите число: ");
                    flag = double.TryParse(Console.ReadLine(), out x);
                } while (!flag);
                GetParts(x);
                SqrtAndPow(x);
                Console.WriteLine("Для выхода из программы нажмите [Esc]. Чтобы повторить решение нажмите [Enter]");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}