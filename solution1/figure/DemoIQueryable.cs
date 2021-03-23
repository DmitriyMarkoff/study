using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figure
{
    public class DemoIQueryable
    {
        public void run()
        {
            int n = 10;
        m1:                                                                        //для повтора
            Quadrilateral[] quadrilateralsArray = new Quadrilateral[n];
            Console.WriteLine("Название фигуры\t\tРавенство сторон\tЦвет");
            Random rand = new Random();
            for (int f = 0; f < n; f++)
            {
                switch (rand.Next() % 4)
                {
                    case 0: quadrilateralsArray[f] = new Quadrilateral("квадрат       ", true, rand.Next(1, 8)); break;
                    case 1: quadrilateralsArray[f] = new Quadrilateral("ромб          ", true, rand.Next(1, 8)); break;
                    case 2: quadrilateralsArray[f] = new Quadrilateral("трапеция      ", false, rand.Next(1, 8)); break;
                    case 3: quadrilateralsArray[f] = new Quadrilateral("параллелограмм", false, rand.Next(1, 8)); break;
                }
                Console.WriteLine("" + quadrilateralsArray[f].Name + "\t\t" + (quadrilateralsArray[f].Equilateral ? "да" : "нет") + "\t\t\t" + quadrilateralsArray[f].GreyColor);
            }

            string startb;
            bool exist = false;

            Console.Write("\nПример использования Where. ВВедите первую букву названия фигуры:");
            startb = Convert.ToString(Console.ReadLine()).ToLower();
            var selectedFigures = quadrilateralsArray.Where(t => t.Name.StartsWith(startb)).OrderBy(t => t.Name);
            foreach (var s in selectedFigures)
            {
                Console.WriteLine("" + s.Name + "\t\t" + (s.Equilateral ? "да" : "нет") + "\t\t\t" + s.GreyColor);
                exist = true;
            }
            if (!exist) Console.Write("\nВ наборе нет фигур, начинающихся на эту букву");

            Console.WriteLine("\nПример использования GroupBy.");
            var selectedFigures1 = quadrilateralsArray.GroupBy(h => h.Name).Select(g => new { Name = g.Key, Count = g.Count() }).OrderBy(h => h.Name);
            foreach (var s in selectedFigures1)
            {
                Console.WriteLine("" + s.Name + " count=" + s.Count);
            }

            Console.WriteLine("\nПример использования Any.");
            bool selectedFigures2 = quadrilateralsArray.Any(m => (m.Name).Trim() == "квадрат");
            if (selectedFigures2)
            {
                Console.WriteLine("в наборе есть квадраты");
            }
            else
            {
                Console.WriteLine("в наборе нет квадратов");
            }

            Console.WriteLine("\nПример использования All.");
            bool selectedFigures3 = quadrilateralsArray.All(m1 => m1.Equilateral == true);
            if (selectedFigures3)
            {
                Console.WriteLine("в наборе все фигуры равносторонние");
            }
            else
            {
                Console.WriteLine("в наборе не все фигуры равносторонние");
            }

            Console.WriteLine("\nПример использования min, max.");
            int selectedFigures4 = quadrilateralsArray.Max(m2 => m2.GreyColor);
            int selectedFigures5 = quadrilateralsArray.Min(m2 => m2.GreyColor);
            Console.WriteLine("максимальная яркость: " + selectedFigures4);
            Console.WriteLine("минимальная яркость: " + selectedFigures5);

            //int dd = Convert.ToInt16(Console.ReadLine());   //для повтора
            //if (dd == 1) goto m1;

            Console.ReadKey();

        }
    }
}
