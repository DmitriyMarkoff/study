﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figure
{
    class Triangle : Figure
    {
        public Triangle(double a, double b, double c)
        {
            Existence = true;
            Name = "треугольник";
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
            {
                SideA = a;
                SideB = b;
                SideC = c;
            }
            else
            {
                Existence = false; 
                throw new ArgumentException("Ошибка ввода данных!");
                //Console.WriteLine("Ошибка ввода данных");
            }
        }

        public override double Square()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public override double Perimeter()
        {
            return SideA + SideB + SideC;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Фигура: {0}", Name);
            Console.WriteLine("Площадь: {0}", Square());
            Console.WriteLine("Периметр: {0}\n", Perimeter());
        }
    }
}
