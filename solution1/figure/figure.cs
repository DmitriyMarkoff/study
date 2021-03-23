using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figure
{
    public abstract class Figure 
    {
        public string Name { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public bool Existence { get; set; }
        public double Radius { get; set; }

        public abstract double Square();
        public abstract double Perimeter();
    }
 }
