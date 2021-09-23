using System;

namespace Task06
{
    class MainClass
    {
        public static double Factorial(int n)
        {
            if (n<=1)
            {
                return 1.0;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public static double Sum1(double x)
        {
            int i = 2;
            double sum = x*x;
            double _sum = 0;
            while(Math.Abs(_sum - sum)>0)
            {
                _sum = sum;
                sum += Math.Pow(-1, i-1)*((Math.Pow(x, 2 * i)*Math.Pow(2, 2*i-1))/Factorial(2*i));
                i++;
            }
            return sum;
        }

        public static double Sum2(double x)
        {
            int i = 1;
            double sum = 1;
            double _sum = 0;
            while (Math.Abs(_sum - sum) > 0)
            {
                _sum = sum;
                sum += Math.Pow(x, i)/Factorial(i);
                i++;
            }
            
            return sum;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(Sum1(x));
            Console.WriteLine(Sum2(x));

        }
    }
}
