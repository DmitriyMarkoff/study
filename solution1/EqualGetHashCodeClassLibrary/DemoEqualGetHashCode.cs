using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EqualGetHashCodeClassLibrary
{
    public class DemoEqualGetHashCode
    {
        public void run()
        {
            string s1 = "строка1";
            string s2 = "строка1";
            string s3 = s1;
            var b1 = s1 == s2;
            var b2 = s1 == s3;
            var b3 = s1.Equals(s2);
            var b4 = s1.Equals(s3);
            Console.WriteLine("равенство s1 и s2: " + b1.ToString()); //непонятно
            Console.WriteLine("равенство s1 и s3: " + b2.ToString());
            Console.WriteLine("эквивалентность s1 и s2: " + b3.ToString());
            Console.WriteLine("эквивалентность s1 и s3: " + b4.ToString());

            Person[] People = new Person[4];
            People[0] = new Person("Иванов", "2000.12.15", "Тирасполь", "123456");
            People[1] = new Person("Иванова", "2000.12.15", "Тирасполь", "123456");
            People[2] = new Person("Иванов", "2000.12.15", "Тирасполь", "123456");
            People[3] = People[0];
            int i = 1;

            Console.WriteLine("Исходные данные: ");
            foreach (Person p in People)
                Console.WriteLine("" + i++ + ") " + p.SurnameName + "  " + p.DateOfBirth + "  " + p.PlaceOfBirth + "  " + p.Passport);

            Console.WriteLine("\nРезультат использования == ");
            var eq1 = People[0] == People[1];
            Console.WriteLine("равенство 1 и 2: " + eq1.ToString());
            eq1 = People[0] == People[2];
            Console.WriteLine("равенство 1 и 3: " + eq1.ToString());
            eq1 = People[0] == People[3];
            Console.WriteLine("равенство 1 и 4: " + eq1.ToString());

            Console.WriteLine("\nРезультат использования встроенного Equals() ");
            eq1 = People[0].Equals(People[1]);
            Console.WriteLine("равенство 1 и 2: " + eq1.ToString());
            eq1 = People[0].Equals(People[2]);
            Console.WriteLine("равенство 1 и 3: " + eq1.ToString());
            eq1 = People[0].Equals(People[3]);
            Console.WriteLine("равенство 1 и 4: " + eq1.ToString());

            Console.WriteLine("\nРезультат использования перегруженного Equals() ");
            eq1 = People[0].Equals1(People[1]);
            Console.WriteLine("равенство 1 и 2: " + eq1.ToString());
            eq1 = People[0].Equals1(People[2]);
            Console.WriteLine("равенство 1 и 3: " + eq1.ToString());
            eq1 = People[0].Equals1(People[3]);
            Console.WriteLine("равенство 1 и 4: " + eq1.ToString());

            Console.WriteLine("\nРезультат использования встроенного GetHashCode() ");
            long hs;
            for (i = 0; i < 4; i++)
            {
                hs = People[i].GetHashCode();
                Console.WriteLine("HashCode {0}: " + hs.ToString(), i + 1);
            }
            
            Console.WriteLine("\nРезультат использования перегруженного GetHashCode() ");
            for (i = 0; i < 4; i++)
            {
                hs = People[i].GetHashCode1();
                Console.WriteLine("HashCode {0}: " + hs.ToString(), i + 1);
            }
            
            Console.ReadKey();
        }
    }
}
