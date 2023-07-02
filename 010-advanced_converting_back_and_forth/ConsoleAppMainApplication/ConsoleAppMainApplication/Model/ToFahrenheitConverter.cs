using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMainApplication.Model
{
    internal class ToFahrenheitConverter : IConverter
    {
        public ToFahrenheitConverter() { }

        public string Convert(double celsius)
        {
            return $"{(celsius * 1.8) + 32} ºF";
        }

    }
}
