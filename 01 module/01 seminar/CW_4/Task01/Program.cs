using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            double p;
            double n = 1;
            do
            {
                p = s;
                s += 1 / (n * (n + 1) * (n + 2));
                n += 1;
            } while (s != p);

            Console.WriteLine(s);
            
            
            float s1 = 0;
            float p1;
            float n1 = 1;
            do
            {
                p1 = s1;
                s1 += 1 / (n1 * (n1 + 1) * (n1 + 2));
                n1 += 1;
            } while (s1 != p1);

            Console.WriteLine(s1);
        }
    }
}