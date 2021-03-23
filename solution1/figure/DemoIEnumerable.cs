using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figure
{
    public class DemoIEnumerable
    {
        public void run()
        {
            Quadrilateral[] quadrilateralsArray = new Quadrilateral[4]
        {
            new Quadrilateral("квадрат       ", true, 15),
            new Quadrilateral("ромб          ", true, 25),
            new Quadrilateral("трапеция      ", false, 40),
            new Quadrilateral("параллелограмм", false, 74)
        };

            Quadrilaterals quadrilateralsList = new Quadrilaterals(quadrilateralsArray);
            Console.WriteLine("Название фигуры\t\tРавенство сторон");
            Console.WriteLine("\n\t\tforeach\n");
            foreach (Quadrilateral q in quadrilateralsList)
                Console.WriteLine("" + q.Name + "\t\t" + (q.Equilateral ? "да" : "нет"));
            Console.WriteLine("\n\n\t\twhile\n");
            int i = 0;
            while (i < quadrilateralsArray.Length)
                Console.WriteLine("" + quadrilateralsArray[i].Name + "\t\t" + quadrilateralsArray[i++].Equilateral);
            Console.ReadKey();
        }
    }
}
