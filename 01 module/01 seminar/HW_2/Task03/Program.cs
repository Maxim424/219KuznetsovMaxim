using System;

namespace Task03
{
    class MainClass
    {
        public static void Solve(double a, double b, double c) {
            double d = b * b - 4 * a * c;
            switch (d)
            {
                case > 0:
                    double x1 = (-b - Math.Sqrt(d)) / 2*a;
                    double x2 = (-b + Math.Sqrt(d)) / 2*a;
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                    break;
                case 0:
                    double x = (-b) / 2 * a;
                    Console.WriteLine("x = " + x);
                    break;
                case < 0:
                    Console.WriteLine("Решений нет");
                    break;
            }
        }

        public static void Main(string[] args)
        {
            double a, b, c;
            bool flag1, flag2, flag3;
            do
            {
                do
                {
                    Console.WriteLine("Введите A: ");
                    flag1 = double.TryParse(Console.ReadLine(), out a);
                } while (!flag1);
                do
                {
                    Console.WriteLine("Введите B: ");
                    flag2 = double.TryParse(Console.ReadLine(), out b);
                } while (!flag2);
                do
                {
                    Console.WriteLine("Введите C: ");
                    flag3 = double.TryParse(Console.ReadLine(), out c);
                } while (!flag3);
                Solve(a, b, c);
                Console.WriteLine("Для выхода из программы нажмите [Esc]. Чтобы повторить решение нажмите [Enter]");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            
        }
    }
}
