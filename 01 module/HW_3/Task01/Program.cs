using System;

namespace Task01
{
    class Program
    {
        public static bool IsG(double x, double y)
        {
            if (x * x + y * y <= 2 && x >= 0 && y <= x)
            {
                return true;
            }
            else
            {
                return false;
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

            Console.WriteLine(IsG(x, y));
        }
    }
}