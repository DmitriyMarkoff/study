using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace figure
{
    class Triangle : Figure
    {
        public Triangle(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c>0 && a + b > c && a + c > b && b + c >a)
            {
                SideA = a;
                SideB = b;
                SideC = c;
            }
            else
                throw new ArgumentException("Ошибка ввода данных!");
        }

        public override double Square()
        {
            return SideA * SideB * SideC;
        }

        public override double Perimeter()
        {
            return SideA + SideB + SideC;
        }


        public void PrintInfo()
        {
            //if (Length == Width)
                Console.WriteLine("Фигура: треугольник");
            //else
            //    Console.WriteLine("Фигура: прямоугольник");
            //Console.WriteLine("Ширина: {0}", Width);
            //Console.WriteLine("Длина: {0}", Length);
            Console.WriteLine("Площадь: {0}", Square());
            Console.WriteLine("Периметр: {0}\n", Perimeter());
        }
    }
}
