using System;
using System.Collections;

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
            RegularPolygon[] regularPolygons = new RegularPolygon[n];
            double[] arr = new double[n];
            double min = double.MaxValue;
            double max = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите количество сторон {i+1}-го многоулольника");
                int sides = int.Parse(Console.ReadLine());
                Console.WriteLine($"Введите радиус вписанной окружности {i + 1}-го многоулольника");
                int radius = int.Parse(Console.ReadLine());
                regularPolygons[i] = new RegularPolygon(sides, radius);
                double area = regularPolygons[i].FindTheArea();
                arr[i] = area;
                if (area<min)
                {
                    min = area;
                }
                if (area > max)
                {
                    max = area;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i]==min)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (arr[i]==max)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ResetColor();
                }
                Console.WriteLine($"Площадь {i+1}-го многоугольника: {regularPolygons[i].FindTheArea()}");
            }
        }
    }
}
