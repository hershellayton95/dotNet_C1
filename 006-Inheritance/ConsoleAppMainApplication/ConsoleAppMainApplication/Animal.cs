using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMainApplication
{
    internal class Animal
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine("Sound of Animal");
        }
    }

    internal class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Woof!");
        }
    }

    internal class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }

    internal class Horse : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("HiHiHi!"); //I don't Know about horse!
        }
    }
}
