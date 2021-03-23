using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figure
{
    class FigureComparer : IComparer<Figure>
    {
        public int Compare(Figure f1, Figure f2)
        {
            if (f1.Perimeter() > f2.Perimeter())
                return 1;
            else if (f1.Perimeter() < f2.Perimeter())
                return -1;
            else
                return 0;
        }
    }
}
