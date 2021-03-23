using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figure
{
    class Rectangle : Figure
    {
        public Rectangle(double lenght, double width)
        {
            if (lenght > 0 && width > 0)
            {
                Length = lenght;
                Width = width;
            }
            else
                throw new ArgumentException("Ошибка ввода данных!");
            if (Length == Width)
                Name = "квадрат   ";
            else
                Name = "прямоугольник";
        }
        
        public override double Square()
        {
            return this.Length * this.Width;
        }

        public override double Perimeter()
        {
            return 2*(this.Length + this.Width);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Фигура: {0}", Name);
            Console.WriteLine("Ширина: {0}", Width);
            Console.WriteLine("Длина: {0}", Length);
            Console.WriteLine("Площадь: {0}", Square());
            Console.WriteLine("Периметр: {0}\n", Perimeter());

        }
    }
}
