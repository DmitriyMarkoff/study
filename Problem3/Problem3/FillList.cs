using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Problem3
{
    public class FillList
    {
        public long FillListInternalGetHashCode(int m, bool truth)
        {
            //m = n;
            List<Person> people = new List<Person>();
            Random rand = new Random();
            Stopwatch stopWatch = new Stopwatch();
            string[] SurnameArray = { "Иванов", "Петров", "Сидоров", "Николаев", "Васильев", "Андреев" };
            string[] NameArray = { "Иван", "Петр", "Сидор", "Николай", "Василий", "Андрей" };
            string[] PatronymicArray = { "Иванович", "Петрович", "Сидорович", "Николаевич", "Васильевич", "Андреевич" };
            string[] PlaceOfBirth = { "Тирасполь", "Бендеры", "Каменка", "Григориополь", "Рыбница", "Слободзея" };
            stopWatch.Start();
            for (int i = 0; i < m; i++)
            {
                Person _tempPerson = new Person("" + SurnameArray[rand.Next(0, 5)] + " " + NameArray[rand.Next(0, 5)] + " " + PatronymicArray[rand.Next(0, 5)],
                                      "" + rand.Next(1970, 2000) + "." + rand.Next(1, 12) + "." + rand.Next(1, 28),
                                      "" + PlaceOfBirth[rand.Next(0, 5)],
                                           rand.Next(100000, 999999).ToString());
                people.Add(_tempPerson);
                if (truth)
                    _tempPerson.GetHashCode();
                else
                    _tempPerson.GetHashCode1();
            }
            stopWatch.Stop();

            //foreach (Person p in people)
            //    Console.WriteLine(p.SurnameName + "\t" + p.DateOfBirth + "\t" + p.PlaceOfBirth + "\t" + p.Passport + "\t" + p.GetHashCode());

            //Console.WriteLine(stopWatch.ElapsedMilliseconds.ToString());
            //Console.WriteLine(stopWatch.ElapsedTicks.ToString());
            //Console.ReadKey();
            return stopWatch.ElapsedMilliseconds;
        }
    }
}
