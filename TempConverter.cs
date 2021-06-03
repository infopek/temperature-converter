using System;

namespace TempConverter
{
    class Program
    {
        // Convert temperature (°C) to K or °F
        static void Main(string[] args)
        {
            double cTemp = 32;

            Console.WriteLine(ToFahrenheit(cTemp));
            Console.WriteLine(ToKelvin(cTemp));

            Console.ReadLine();
        }

        // Convert Celsius to Kelvin
        static double ToKelvin(double temp)
        {
            return temp + 273.15;
        }

        // Convert Celsius to Fahrenheit
        static double ToFahrenheit(double temp)
        {
            return (temp * 9 / 5) + 32;
        }
    }
}
