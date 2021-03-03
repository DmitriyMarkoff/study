using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace figure
{
    public abstract class Figure
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double Radius { get; set; }

        public abstract double Square();
        public abstract double Perimeter();

    }
}
