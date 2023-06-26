using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMainApplication.Model
{
    internal class Input
    {
        public static double InputToDouble()
        {
            string? input = null;
            double num = 0d;
            bool parseBool = false;

            Console.WriteLine("Insert a number");
            input = Console.ReadLine();
            Console.WriteLine("The result is");
            parseBool = double.TryParse(input, out num);

            if (parseBool)
            {
                return num;
            }
            else
            {
                throw new Exception("number not valid");
            }

        }
    }
}
