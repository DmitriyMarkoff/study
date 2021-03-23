using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figure
{
    class ComparTo : IComparable
    {
        double perim { get; set; }
        public int CompareTo(object o)
        {
            if (o == null) return 1;
            Figure fig1 = o as Figure;
            if (fig1 != null)
                return this.perim.CompareTo(fig1.Perimeter());
            else
                throw new Exception("Невозможно сравнить два объекта");

        }
    }
}
