using System;

namespace Task07
{
    class MainClass
    {
        public static void Calculate(int a, int b, out int gcd, out int lcm)
        {
            gcd = a;
            lcm = a;
            int res = 1;
            int mx = Math.Max(a, b);
            int mn = Math.Min(a, b);
            while (res!=0)
            {
                res = mx % mn;
                mx = mn;
                mn = res;

            }
            gcd = mx;

            lcm = a * b / gcd;
        }

        public static void Main(string[] args)
        {
            int gcd;
            int lcm;
            Console.WriteLine("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            Calculate(a, b, out gcd, out lcm);
            Console.WriteLine("НОД: " + gcd);
            Console.WriteLine("НОК: " + lcm);
        }
    }
}
