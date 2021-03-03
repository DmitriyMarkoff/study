using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace figure
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
            if (Length == Width)
                Console.WriteLine("Фигура: квадрат");
            else
                Console.WriteLine("Фигура: прямоугольник");
            Console.WriteLine("Ширина: {0}", Width);
            Console.WriteLine("Длина: {0}", Length);
            Console.WriteLine("Площадь: {0}", Square());
            Console.WriteLine("Периметр: {0}\n", Perimeter());

        }
    }
}
