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

        public string PolygonData()
        {
            double a = 2 * Radius * Math.Tan(Math.PI / (double)SidesNumber);
            Perimeter = a * SidesNumber;
            Area = SidesNumber * Math.Pow(Radius, 2) * Math.Tan(Math.PI / (double)SidesNumber);
            string result = "SidesNumber: " + SidesNumber + "\n" + "Radius: " + Radius + "\n" + "Perimeter: " + Perimeter + "\n" + "Area: " + Area + "\n";
            return result;
        }

        public int SidesNumber { get => sidesNumber; set => sidesNumber = value; }
        public double Radius { get => radius; set => radius = value; }
        public double Perimeter { get; set; }
        public double Area { get; set; }
    }
}
