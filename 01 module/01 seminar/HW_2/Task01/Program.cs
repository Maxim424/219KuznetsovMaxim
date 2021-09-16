using System;

namespace Task01
{
    class MainClass
    {
        public static double CalculateF(double x)
        {
            double F = -4;
            double x2 = x * x;
            double x3 = x2 * x;
            double x4 = x3 * x;
            for (int i = 0; i < 12; i++)
            {
                F += x4;
            }
            for (int i = 0; i < 9; i++)
            {
                F += x3;
            }
            for (int i = 0; i < 3; i++)
            {
                F -= x2;
            }
            F = F + x + x;
            return F;
        }

        public static void Main(string[] args)
        {
            double x;
            bool flag;
            do {
                do
                {
                    Console.WriteLine("Введите x: ");
                    flag = double.TryParse(Console.ReadLine(), out x);
                    double F = CalculateF(x);
                    if (flag)
                    {
                        Console.WriteLine("F(x) = " + F);
                    }

                } while (!flag);
                Console.WriteLine("Для выхода из программы нажмите [Esc]. Чтобы повторить решение нажмите [Enter]");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            
        }
    }
}
