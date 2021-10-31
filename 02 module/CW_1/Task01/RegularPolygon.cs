using System;
namespace Task01
{
    public class RegularPolygon
    {
        private int sidesNumber;
        private double radius;

        public RegularPolygon(int sidesNumber, double radius)
        {
            SidesNumber = sidesNumber;
            Radius = radius;
        }

        public RegularPolygon()
        {
            SidesNumber = 3;
            Radius = 10;
        }

        public double FindTheSide()
        {
            return 2 * Radius * Math.Tan(Math.PI / (double)SidesNumber);
        }

        public double FindThePerimeter()
        {
            return FindTheSide() * SidesNumber;
        }

        public double FindTheArea()
        {
            return SidesNumber * Math.Pow(Radius, 2) * Math.Tan(Math.PI / (double)SidesNumber);
        }

        public string PolygonData()
        {
            string result = "SidesNumber: " + SidesNumber + "\n" + "Radius: " + Radius + "\n" + "Perimeter: " + FindThePerimeter() + "\n" + "Area: " + FindTheArea() + "\n";
            return result;
        }

        public int SidesNumber { get => sidesNumber; set => sidesNumber = value; }
        public double Radius { get => radius; set => radius = value; }
    }
}
