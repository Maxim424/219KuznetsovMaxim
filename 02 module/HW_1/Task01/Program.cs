using System;

namespace Task01
{

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public readonly double r;
        public readonly double a;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
            a = CalculateA();
            r = CalculateR();
        }

        public Point()
        {
        }

        public double CalculateR()
        {
            return Math.Pow(Math.Pow(X, 2) + Math.Pow(Y, 2), 0.5);
        }

        public double CalculateA()
        {
            return Math.Atan(Y / X);
        }

        public override string ToString()
        {
            return $"Расстояние от начала координат: {r}. Угол: {a}. X: {X}. Y: {Y}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 5);
            Point p2 = new Point(1, 6);
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Point p3 = new Point(x, y);
            double[] arr = new double[3];
            arr[0] = p1.r;
            arr[1] = p2.r;
            arr[2] = p3.r;
            Array.Sort(arr);
            for (int i = 0; i < 3; i++)
            {
                if (p1.r == arr[i])
                {
                    Console.WriteLine(p1.ToString());
                }
                else if (p2.r==arr[i])
                {
                    Console.WriteLine(p2.ToString());
                }
                else
                {
                    Console.WriteLine(p3.ToString());
                }
                
            }
        }
    }
}
