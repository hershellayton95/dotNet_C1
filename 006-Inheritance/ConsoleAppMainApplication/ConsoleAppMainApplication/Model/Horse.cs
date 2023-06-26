using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMainApplication.Model
{
    internal class Horse : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("HiHiHi!"); //I don't Know about horse!
        }
    }
}
