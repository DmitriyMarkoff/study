using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figure
{
    class Circle : Figure
    {
        public Circle(double r)
        {
            Name = "круг      ";
            if (r > 0)
            {
                Radius = r;
            }
            else
                throw new ArgumentException("Ошибка ввода данных!");
        }

        public override double Square()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override double Perimeter()
        {
            return 2 * Radius * Math.PI;
        }


        public void PrintInfo()
        {
            Console.WriteLine("Фигура: {0}", Name);
            Console.WriteLine("Площадь: {0}", Square());
            Console.WriteLine("Периметр: {0}\n", Perimeter());
        }
    }
}
