using System;
using System.Collections.Generic;
using System.Text;

namespace _5jancw
{
    internal class Phone:Product
    {

        public int Simcount;
        public override string ToString()
        {
            return $"Name:{Name}, Price:{Price}, Simcount:{Simcount}";
        }
    }
}
