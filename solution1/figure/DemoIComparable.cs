using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figure
{
    public class DemoIComparable //: IComparable
    {
        //double perim { get; set; }
        //public int CompareTo(object o)
        //{
        //    if (o == null) return 1;
        //    Figure fig1 = o as Figure;
        //    if (fig1 != null)
        //        return this.perim.CompareTo(fig1.Perimeter());
        //    else
        //        throw new Exception("Невозможно сравнить два объекта");
        
        //}
        
        public void run()
        {
            int n = 10;
        m1:
            Figure[] Figures1 = new Figure[n];
            Console.WriteLine("Название фигуры\t\tПериметр\tПлощадь");
            Random rand = new Random();
            int f=0;
            while (f < n)
            {
                switch (rand.Next() % 3)
                {
                    case 0: Figures1[f++] = new Rectangle(rand.Next(1, 8), rand.Next(1, 8)); break;
                    case 1: Figures1[f++] = new Circle(rand.Next(1, 8)); break;
                    case 2:
                        try
                        {
                            Figures1[f++] = new Triangle(rand.Next(1, 8), rand.Next(1, 8), rand.Next(1, 8)); 
                        }
                        catch (Exception)
                        {
                            f--;
                        }
                        break;

                    }
                //f++;
                //Console.WriteLine("{0}\t\t{1:f2}\t\t{2:f2}", Figures1[f].Name, Figures1[f].Perimeter(), Figures1[f].Square());
            }
            
            foreach (Figure fig in Figures1)
                Console.WriteLine("{0}\t\t{1:f2}\t\t{2:f2}", fig.Name, fig.Perimeter(), fig.Square());

            Console.WriteLine("\nСортировка по площади при помощи CompareTo");
            Array.Sort(Figures1);
            foreach (Figure fig in Figures1)
                Console.WriteLine("{0}\t\t{1:f2}\t\t{2:f2}", fig.Name, fig.Perimeter(), fig.Square());

            Console.WriteLine("\nСортировка по периметру при помощи IComparer");
            Array.Sort(Figures1, new FigureComparer());
            foreach (Figure fig in Figures1)
                Console.WriteLine("{0}\t\t{1:f2}\t\t{2:f2}", fig.Name, fig.Perimeter(), fig.Square());
            
            //int dd = Convert.ToInt16(Console.ReadLine());
            //if (dd == 1) goto m1;

            Console.ReadKey();

        }
        
    }
}
