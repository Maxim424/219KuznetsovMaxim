using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            RegularPolygon regularPolygon = new RegularPolygon();
            regularPolygon.Radius = 20;
            regularPolygon.SidesNumber = 5;
            Console.WriteLine(regularPolygon.PolygonData());

            Console.WriteLine("Введите количество элементов массива");
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            RegularPolygon[] regularPolygons = new RegularPolygon[n];
            for (int i = 0; i < n; i++)
            {
                regularPolygons[i] = new RegularPolygon(random.Next(1, 10), random.Next(1, 10));
                Console.WriteLine(regularPolygons[i].PolygonData());
                Console.WriteLine();
            }
        }
    }
}
