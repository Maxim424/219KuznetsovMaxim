using System;

namespace Task03
{
    class Program
    {
        public static double G(double x)
        {
            if (x <= 0.5)
            {
                return Math.Sin(Math.PI / 2.0);
            }
            else
            {
                return Math.Sin((Math.PI * (x - 1)) / 2.0);
            }
        }
        
        static void Main(string[] args)
        {
            bool flag;
            double x;
            do
            {
                Console.WriteLine("Введите x: ");
                flag = double.TryParse(Console.ReadLine(), out x);
            } while (!flag);
            Console.WriteLine(G(x));
        }
    }
}