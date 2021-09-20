using System;
using System.Threading.Channels;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите U: ");
            double U = double.Parse(Console.ReadLine());
            Console.Write("Введите R: ");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("I = " + (U/R));
            Console.WriteLine("P = " + ((U*U)/R));
        }
    }
}