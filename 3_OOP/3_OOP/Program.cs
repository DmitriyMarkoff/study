using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solution1
{
    class operation
    {
        public double x;
        public double y;
        public char z;
        public void Show()
        {
            Console.WriteLine("Аргументы: ({0}, {1})", x, y);
        }
    }

    class plus : operation
    {
        new public void Show()
        {
            Console.WriteLine("{0}+{1}={2}", x, y, x + y);
        }
    }
    class minus : operation
    {
        new public void Show()
        {
            Console.WriteLine("{0}-{1}={2}", x, y, x - y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            double arg1;
            double arg2;
            char oper;
            Console.Write("Задание 3.\nВведите первый аргумент:");
            arg1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второй аргумент:");
            arg2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите знак операции (-,+):");
            oper = Convert.ToChar(Console.ReadLine());
            operation op = new operation { x = arg1, y = arg2 };
            op.Show();
            if (oper == '+')
            {
                plus op1 = new plus { x = arg1, y = arg2, z = oper };
                op1.Show();
            }
            else
            {
                minus op2 = new minus { x = arg1, y = arg2, z = oper };
                op2.Show();
            }
           Console.ReadKey();
        }
    }
}
