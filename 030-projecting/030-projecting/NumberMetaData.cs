using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_projecting
{
    internal class NumberMetaData
    {
        public int Number { get; set; }

        public NumberMetaData(int number)
        {
            Number = number;
        }

        public bool IsEven()
        {
            if (Number % 2 == 0) return true;
            return false;
        }

        public int NumberOfCharacters()
        {
            return Number.ToString().Length;
        }
    }
}
