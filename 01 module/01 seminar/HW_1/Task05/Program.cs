using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину катета a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите длину катета b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Гипотенуза c = " + (Math.Pow(a*a+b*b, 0.5)));
        }
    }
}