using System;

namespace Task1
{
    public delegate void CoordChanged(Dot d);

    public class Dot
    {
        private double x;
        private double y;
        private Random random = new Random();

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Dot(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public event CoordChanged OnCoordChanged;

        public void DotFlow()
        {
            for (int i = 0; i < 10; i++)
            {
                X = random.NextDouble() * 20 - 10;
                Y = random.NextDouble() * 20 - 10;
                if (X < 0 && Y < 0)
                {
                    OnCoordChanged(this);
                }
            }
        }
    }

    public class Program
    {
        static void PrintInfo(Dot d)
        {
            Console.WriteLine($"x: {d.X}\ty: {d.Y}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты x и y через пробел:");
            string[] line = Console.ReadLine().Split();
            double x = double.Parse(line[0]);
            double y = double.Parse(line[1]);
            Dot D = new Dot(x, y);
            D.OnCoordChanged += PrintInfo;
            D.DotFlow();
        }
    }
}
