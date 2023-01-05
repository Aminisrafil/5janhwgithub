using System;
using System.Collections.Generic;
using System.Text;

namespace _5jancw
{
    internal abstract class Product
    {
        public string Name;
        public double Price;

        public override string ToString()
        {
            return $"Name:{Name},Price:{Price}";
        }
    }
}
