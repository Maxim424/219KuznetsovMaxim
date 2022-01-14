using System;

namespace Task1
{
    class Program
    {
        delegate int Cast(double x);

        public static int ToTheNearestEven(double x)
        {
            int t = (int)x;
            if (t % 2 == 0)
            {
                return t;
            }
            else
            {
                return t + 1;
            }
        }

        public static int CalculateExponent(double x)
        {
            int t = (int)x;
            return t.ToString().Length;
            
        }

        static void Main(string[] args)
        {
            Cast cast1 = delegate (double x)
            {
                int t = (int)x;
                if (t%2==0)
                {
                    return t;
                }
                else
                {
                    return t + 1;
                }
            };
            Cast cast2 = delegate (double x)
            {
                int t = (int)x;
                return t.ToString().Length;
            };
            Console.WriteLine("Введите вещественное число:");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine($"cast1: {cast1(num)}");
            Console.WriteLine($"cast2: {cast2(num)}");

            Cast cast = cast1;
            cast += cast2;
            Console.WriteLine($"cast: {cast(num)}");

            Cast lambdaCast = x => (int)x + (int)x % 2;
            Console.WriteLine($"lambdaCast1: {lambdaCast.Invoke(num)}");
            lambdaCast += x => ((int)x).ToString().Length;
            Console.WriteLine($"lambdaCast2: {lambdaCast.Invoke(num)}");
            lambdaCast -= x => ((int)x).ToString().Length;
            Console.WriteLine($"lambdaCast: {lambdaCast.Invoke(num)}");

            Cast MethodCast = ToTheNearestEven;
            Console.WriteLine($"MethodCast1: {MethodCast.Invoke(num)}");
            MethodCast += CalculateExponent;
            Console.WriteLine($"MethodCast2: {MethodCast.Invoke(num)}");
            MethodCast -= CalculateExponent;
            Console.WriteLine($"MethodCast: {MethodCast.Invoke(num)}");
        }
    }
}
