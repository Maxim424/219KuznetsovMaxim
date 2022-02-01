using System;

namespace Task2
{
    class Point
    {
        private double x, y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double CalculateDistance(Point p)
        {
            return Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
        }
    }

    class TriangleComp
    {
        private Point p1, p2, p3;
        private double a12, a23, a13;

        public TriangleComp()
        {
            p1 = new Point(0, 0);
            p2 = new Point(5, 6);
            p3 = new Point(-1, 4);

            a12 = p1.CalculateDistance(p2);
            a23 = p2.CalculateDistance(p3);
            a13 = p1.CalculateDistance(p3);
        }

        public TriangleComp(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            p1 = new Point(x1, y1);
            p2 = new Point(x2, y2);
            p3 = new Point(x3, y3);

            a12 = p1.CalculateDistance(p2);
            a23 = p2.CalculateDistance(p3);
            a13 = p1.CalculateDistance(p3);
        }

        public TriangleComp(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;

            a12 = p1.CalculateDistance(p2);
            a23 = p2.CalculateDistance(p3);
            a13 = p1.CalculateDistance(p3);
        }

        public double Area()
        {
            double p = (a12 + a23 + a13) / 2;
            return Math.Sqrt(p * (p - a12) * (p - a23) * (p - a13));
        }

        private double sign(Point p1, Point p2, Point p3)
        {
            return (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);
        }

        public bool PointInTriangle(Point pt)
        {
            double d1, d2, d3;
            bool has_neg, has_pos;
            d1 = sign(pt, p1, p2);
            d2 = sign(pt, p2, p3);
            d3 = sign(pt, p3, p1);
            has_neg = (d1 < 0) || (d2 < 0) || (d3 < 0);
            has_pos = (d1 > 0) || (d2 > 0) || (d3 > 0);
            return !(has_neg && has_pos);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TriangleComp tc = new TriangleComp();
            Console.WriteLine($"Area: {tc.Area()};\nPoint in triangle: {tc.PointInTriangle(new Point(1, 1))}.");
        }
    }
}
