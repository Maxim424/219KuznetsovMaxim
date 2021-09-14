using System;

namespace Task01
{
    class MainClass
    {
        public static bool Function(bool p, bool q) {
            return !(p & q) & !(p | !q);
        }

        public static void Function2(bool p, bool q, out bool f)
        {
            f = !(p & q) & !(p | !q);
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("p    q   f");
            Console.WriteLine("0    0   " + Function(false, false));
            Console.WriteLine("0    1   " + Function(false, true));
            Console.WriteLine("1    0   " + Function(true, false));
            Console.WriteLine("1    1   " + Function(true, true));

            bool f;
            Console.WriteLine();
            Console.WriteLine("p    q   f");
            Function2(false, false, out f);
            Console.WriteLine("0    0   " + f);
            Function2(false, true, out f);
            Console.WriteLine("0    1   " + f);
            Function2(true, false, out f);
            Console.WriteLine("1    0   " + f);
            Function2(true, true, out f);
            Console.WriteLine("1    1   " + f);
        }
    }
}
