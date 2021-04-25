using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Problem3
{
    public class FillDictionary
    {
        public long FillDictionaryInternalGetHashCode(int m, bool truth)
        {
            Dictionary<string, Person> peopleD = new Dictionary<string, Person>();
            Random rand = new Random();
            Stopwatch stopWatch = new Stopwatch();
            string[] SurnameArray = { "Иванов", "Петров", "Сидоров", "Николаев", "Васильев", "Андреев" };
            string[] NameArray = { "Иван", "Петр", "Сидор", "Николай", "Василий", "Андрей" };
            string[] PatronymicArray = { "Иванович", "Петрович", "Сидорович", "Николаевич", "Васильевич", "Андреевич" };
            string[] PlaceOfBirth = { "Тирасполь", "Бендеры", "Каменка", "Григориополь", "Рыбница", "Слободзея" };

            int i = 0, k = 0;
            string PassportNumber;
            stopWatch.Start();
            while (i < m)
            {
                PassportNumber = rand.Next(100000, 999999).ToString();
                if (!peopleD.ContainsKey(PassportNumber))
                {
                    Person _tempPerson = new Person("" + SurnameArray[rand.Next(0, 5)] + " " + NameArray[rand.Next(0, 5)] + " " + PatronymicArray[rand.Next(0, 5)],
                                      "" + rand.Next(1970, 2000) + "." + rand.Next(1, 12) + "." + rand.Next(1, 28),
                                      "" + PlaceOfBirth[rand.Next(0, 5)],
                                           PassportNumber);
                    _tempPerson.GetHashCode();
                    peopleD.Add(PassportNumber, _tempPerson);
                    i++;
                }
                else
                {
                    k++;
                }
            }
            stopWatch.Stop();
            Console.WriteLine("Повторов номера: {0}", k);

            //foreach (KeyValuePair<string, Person> p in peopleD)
            //    Console.WriteLine(p.Value.SurnameName + "\t" + p.Value.DateOfBirth + "\t" + p.Value.PlaceOfBirth + "\t" + p.Value.Passport + "\t" + p.GetHashCode());

            //Console.WriteLine(stopWatch.ElapsedMilliseconds.ToString());
            //Console.WriteLine(stopWatch.ElapsedTicks.ToString());
            //Console.ReadKey();
            return stopWatch.ElapsedMilliseconds;
        }
    }
}
