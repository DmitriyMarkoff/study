using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EqualGetHashCodeClassLibrary;

namespace Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите демо:\n1 - DemoOOP\n2 - DemoIEnumerable\n3 - DemoIQueryable\n4 - DemoIComparable" +
                                            "\n5 - DemoEqualGetHashCode\n0 - выход");
            int z = Convert.ToInt16(Console.ReadLine());
            switch (z)
            {
                case 1: DemoOOP DO = new DemoOOP(); DO.run(); break;
                case 2: DemoIEnumerable DE = new DemoIEnumerable(); DE.run(); break;
                case 3: DemoIQueryable DQ = new DemoIQueryable(); DQ.run(); break;
                case 4: DemoIComparable DC = new DemoIComparable(); DC.run(); break;
                case 5: EqualGetHashCodeClassLibrary.DemoEqualGetHashCode DEH = new EqualGetHashCodeClassLibrary.DemoEqualGetHashCode(); DEH.run(); break;
                case 0: break;

            }
            // Console.ReadKey();
        }
    }
}
