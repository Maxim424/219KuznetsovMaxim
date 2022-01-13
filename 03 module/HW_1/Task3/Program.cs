using System;

namespace Task3
{
    

    class TemperatureConverterImp
    {
        public double ToCelsius(double x)
        {
            return (5.0 / 9.0) * (x - 32);
        }

        public double ToFahrenheit(double x)
        {
            return (9.0 / 5.0) * x + 32;
        }
    }

    static class StaticTempConverters
    {
        public static double CelsiusToKelvin(double x)
        {
            return x + 273.15;
        }

        public static double CelsiusToReaumur(double x)
        {
            return (4.0/5.0) * x;
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
        public delegate double DelegateConvertTemperature(double x);

        static void Main(string[] args)
        {
            TemperatureConverterImp temperatureConverter = new TemperatureConverterImp();
            DelegateConvertTemperature delegateConvert1 = temperatureConverter.ToCelsius;
            DelegateConvertTemperature delegateConvert2 = temperatureConverter.ToFahrenheit;
            DelegateConvertTemperature[] array = new DelegateConvertTemperature[2];
            array[0] = delegateConvert1;
            array[1] = delegateConvert2;
            double temperature = double.Parse(Console.ReadLine());
            Console.WriteLine(array[0].Invoke(temperature));
            Console.WriteLine(array[1].Invoke(temperature));

            DelegateConvertTemperature[] array2 = new DelegateConvertTemperature[3];
            array2[0] = StaticTempConverters.CelsiusToKelvin;
            array2[1] = StaticTempConverters.CelsiusToRankin;
            array2[2] = StaticTempConverters.CelsiusToReaumur;

            temperature = double.Parse(Console.ReadLine());
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"{array2[i].Method}: {array2[i].Invoke(temperature)}");
            }
        }
    }
}
