using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMainApplication.Model
{
    internal class ToCelsiusConverter : IConverter
    {
        public ToCelsiusConverter() { }

        public string Convert(double fahrenheit)
        {
            return $"{(fahrenheit - 32) / 1.8} ºC";
        }

    }
}
