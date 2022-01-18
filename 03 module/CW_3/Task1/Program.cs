using System;

namespace Task1
{
    delegate void SquareSizeChanged(double x);

    class Square
    {
        private double x1;
        private double y1;
        private double x2;
        private double y2;

        public double X1
        {
            get
            {
                return x1;
            }

            set
            {
                x1 = value;
                OnSizeChangeed(Math.Abs(x2 - x1));
            }
        }
        public double Y1
        {
            get
            {
                return y1;
            }

            set
            {
                y1 = value;
                OnSizeChangeed(Math.Abs(y2 - y1));
            }
        }
        public double X2
        {
            get
            {
                return x2;
            }

            set
            {
                x2 = value;
                OnSizeChangeed(Math.Abs(x2-x1));
            }
        }
        public double Y2
        {
            get
            {
                return y2;
            }

            set
            {
                y2 = value;
                OnSizeChangeed(Math.Abs(y2 - y1));
            }
        }

        public Square(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public event SquareSizeChanged OnSizeChangeed;
    }

    class Program
    {
        public static void SquareConsoleInfo(double x)
        {
            Console.WriteLine($"Сторона: {x:F2}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1, y1, x2, y2 каждое с новой строке:");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Square S = new Square(x1, y1, x2, y2);
            S.OnSizeChangeed += SquareConsoleInfo;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите новые координаты x2, y2 каждое с новой строки:");
                S.X2 = double.Parse(Console.ReadLine());
                S.Y2 = double.Parse(Console.ReadLine());
            }
        }
    }
}
