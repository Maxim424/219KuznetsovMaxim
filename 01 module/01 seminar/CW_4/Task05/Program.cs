using System;

namespace Task05
{
    class Program
    {
        public static double Total(double k, double r, uint n)
        {
            if (n == 0)
            {
                return k;
            }
            else
            {
                return Total(k * (r/100.0) + k, r, n - 1);
            }
        }
        
        static void Main(string[] args)
        {
            double k = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine(Total(k, r, n));
        }
    }
}