using System;

namespace Task05
{
    class Program
    {
        public static void Solve(double a, double b, double c)
        {
            bool t1, t2, t3;
            t1 = (a + b > c) ? (true) : (false);
            t2 = (c + b > a) ? (true) : (false);
            t3 = (a + c > b) ? (true) : (false);
            switch (t1 && t2 && t3)
            {
                case true:
                    Console.WriteLine("Неравенство треугольника выполняется");
                    break;
                case false:
                    Console.WriteLine("Неравенство треугольника не выполняется");
                    break;
            }
        }
        
        static void Main(string[] args)
        {
            bool flag1, flag2, flag3;
            double a, b, c;
            do
            {
                do
                {
                    Console.WriteLine("Введите первое число: ");
                    flag1 = double.TryParse(Console.ReadLine(), out a);
                } while (!flag1);
                do
                {
                    Console.WriteLine("Введите второе число: ");
                    flag2 = double.TryParse(Console.ReadLine(), out b);
                } while (!flag2);
                do
                {
                    Console.WriteLine("Введите третье число: ");
                    flag3 = double.TryParse(Console.ReadLine(), out c);
                } while (!flag3);
                Solve(a, b, c);
                Console.WriteLine("Для выхода из программы нажмите [Esc]. Чтобы повторить решение нажмите [Enter]");
            }while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}