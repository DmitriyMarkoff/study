using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 10);
            Triangle triang = new Triangle(8, 7, 5);
            Console.WriteLine("Информация о фигурах:\n");
            rect.PrintInfo();
            triang.PrintInfo();
            Console.ReadKey();
         }
    }
}
