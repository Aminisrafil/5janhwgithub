using System;
using System.Collections.Generic;
using System.Text;

namespace _5jancw
{
    internal class Notebook:Product
    {
        public int Ram;
        public int Storage;
        public override string ToString()
        {
            return $"Name:{Name}, Price:{Price}, Ram:{Ram}, Storage:{Storage}";
        }
    }
}
