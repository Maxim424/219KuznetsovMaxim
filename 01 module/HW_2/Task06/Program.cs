using System;
using System.Globalization;

namespace Task06
{
    class Program
    {
        public static void Calculate(double x, int y, string s)
        {
            double y1 = y / 100.0;
            double res = x * y1;
            if (s == "dollar")
            {
                Console.WriteLine(res.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            }
            else if (s == "euro")
            {
                Console.WriteLine(res.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR")));   
            }
            else if (s == "ruble")
            {
                Console.WriteLine(res.ToString("C", CultureInfo.CreateSpecificCulture("ru-RU")));
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        
        static void Main(string[] args)
        {
            do
            {
                bool flag1, flag2, flag3;
                double x;
                int y;
                String[] str;
                do
                {
                    Console.WriteLine("Введите сначала бюджет, а затем (через пробел) наименование валюты (dollar, euro, ruble): ");
                    str = Console.ReadLine().Split();
                    flag1 = double.TryParse(str[0], out x);
                    if (str[1] == "dollar" || str[1] == "euro" || str[1] == "ruble")
                    {
                        flag2 = true;
                    }
                    else
                    {
                        flag2 = false;
                    }
                } while (!flag1 || !flag2);

                do
                {
                    Console.WriteLine("Введите процент (целое число): ");
                    flag3 = int.TryParse(Console.ReadLine(), out y);
                } while (!flag3);
                Calculate(x, y, str[1]);
                Console.WriteLine("Для выхода из программы нажмите [Esc]. Чтобы повторить решение нажмите [Enter]");
            }while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}