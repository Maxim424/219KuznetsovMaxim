using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, delta;
            bool flag1, flag2;
            do
            {
                Console.WriteLine("Введите a: ");
                flag1 = double.TryParse(Console.ReadLine(), out a);
            } while (!flag1);
            do
            {
                Console.WriteLine("Введите delta: ");
                flag2 = double.TryParse(Console.ReadLine(), out delta);
            } while (!flag2);

            double left = 0.0;
            double s = 0.0;
            while (left+delta<=a)
            {
                double right = left + delta;
                s += ((right * right + left * left) / 2.0) * delta;
                left = right;
            }

            double delta2 = a - left;
            double right2 = left + delta2;
            s += ((right2 * right2 + left * left) / 2.0) * delta2;
            Console.WriteLine("Площадь: " + s);
        }
    }
}