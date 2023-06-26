using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMainApplication.Model
{
    internal class Converter : IConverter
    {
        public Converter() { }

        public string CelsiusToFahrenheit(double celsius)
        {
            return $"{ (celsius * 1.8) + 32} ºF";
        }

        public string FahrenheitToCelsius(double fahrenheit)
        {
            return $"{(fahrenheit - 32) / 1.8} ºC";
        }

    }
}
