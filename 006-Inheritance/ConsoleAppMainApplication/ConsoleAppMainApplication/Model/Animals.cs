using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMainApplication.Model
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public abstract void Speak();
    }
}
