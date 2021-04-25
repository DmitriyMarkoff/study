using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figure
{
    public abstract class Figure : IComparable<Figure>

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

        public int CompareTo(Figure f)
        {
            Figure fig1 = f as Figure;
            if (fig1 != null)
                //return this.Square().CompareTo(fig1.Square());  //по возрастанию
                return fig1.Square().CompareTo(this.Square());   //по убыванию
            else
                throw new Exception("Невозможно сравнить два объекта");

            //if (this.Square() > f.Square())
            //    return 1;
            //if (this.Square() < f.Square())
            //    return -1;
            //else
            //    return 0;
        }
    }
 }
