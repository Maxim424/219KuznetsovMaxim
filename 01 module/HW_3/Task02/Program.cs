using System;

namespace Task02
{
    class Program
    {
        public static double G(double x, double y)
        {
            if (x < y && x > 0)
            {
                return x + Math.Sin(y);
            } else if (x > y && x < 0)
            {
                return y - Math.Cos(x);
            }
            else
            {
                return 0.5 * x * y;
            }
        }
        
        static void Main(string[] args)
        {
            bool xFlag, yFlag;
            double x, y;
            do
            {
                Console.WriteLine("Введите x: ");
                xFlag = double.TryParse(Console.ReadLine(), out x);
            } while (!xFlag);

            do
            {
                Console.WriteLine("Введите y: ");
                yFlag = double.TryParse(Console.ReadLine(), out y);
            } while (!yFlag);

            Console.WriteLine(G(x, y));
        }
    }
}