using System;
using Task04Lib_Shape;

namespace Task01
{
    class Program
    {

        private static Random rnd = new Random();

        static void Main(string[] args)
        {
            int N1 = rnd.Next(3, 6);
            int N2 = rnd.Next(3, 6);
            int N3 = rnd.Next(3, 6);
            Shape[] array = new Shape[N1 + N2 + N3];
            for (int i = 0; i < N1; i++)
            {
                array[i] = new Circle(rnd.NextDouble() * rnd.Next(10));
            }
            for (int i = N1; i < N1 + N2; i++)
            {
                array[i] = new Cylinder(rnd.NextDouble() * rnd.Next(10),
                    rnd.NextDouble() * rnd.Next(10));
            }
            for (int i = N1 + N2; i < N1 + N2 + N3; i++)
            {
                array[i] = new Sphere(rnd.NextDouble() * rnd.Next(10));
            }
            Array.ForEach(array, element =>
            {
                Console.WriteLine($"{element.GetType()}: {element.Area()}");
            });
        }
    }
}
