using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figure
{
    public class DemoOOP
    {
        public void run()
        {
            Rectangle rect = new Rectangle(10, 10);
            Triangle triang = new Triangle(8, 7, 5);
            Circle circle = new Circle(9);
            Console.WriteLine("Информация о фигурах:\n");
            rect.PrintInfo();
            triang.PrintInfo();
            circle.PrintInfo();
            Console.ReadKey();
        }
    }
}
