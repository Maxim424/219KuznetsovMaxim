using System;

namespace Task1
{
    static class StaticTempConverters
    {
        public static double CelsiusToKelvin(double x)
        {
            return x + 273.15;
        }

        public static double CelsiusToReaumur(double x)
        {
            return (4.0 / 5.0) * x;
        }

        public static double CelsiusToRankin(double x)
        {
            return (x + 273.15) * (9.0 / 5.0);
        }

        public static double RankinToCelsius(double x)
        {
            return (x - 491.67) * (5.0 / 9.0);
        }

        public static double ReaumurToCelsius(double x)
        {
            return x * (5.0 / 4.0);
        }

        public static double KelvinToCelsius(double x)
        {
            return x - 273.15;
        }
    }

    class Program
    {
        public delegate double Converter(double x);

        static void Main(string[] args)
        {
            Converter[] array = new Converter[3];
            array[0] = StaticTempConverters.CelsiusToKelvin;
            array[1] = StaticTempConverters.CelsiusToRankin;
            array[2] = StaticTempConverters.CelsiusToReaumur;
            Console.WriteLine("Введите температуру в градусах Цельсия:");
            double temperature = double.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i].Method}: {array[i].Invoke(temperature)}");
            }
        }
    }
}
