using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            passwords pass1 = new passwords { };
            passwords pass2 = new passwords { };
            Console.Write("Задание 6.\nВведите цифровой пароль: ");
            pass1.symbols = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите символьный пароль: ");
            pass2.symbols = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ваш цифровой пароль увеличен вдвое: " + (int)pass1.symbols * 2);
            Console.WriteLine("К Вашему символьному паролю добавлен символ: " + (string)pass2.symbols + 1);
            Console.ReadKey();
        }
    }
}
