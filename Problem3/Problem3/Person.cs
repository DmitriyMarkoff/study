using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem3
{
    class Person
    {
        public string SurnameName { get; set; }
        //public DateTime DateOfBirth { get; set; }
        public string DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Passport { get; set; }
        public Person(string surnamename, string dateofbirth, string placeofbirth, string passport)
        {
            SurnameName = surnamename;
            //DateOfBirth = (Convert.ToDateTime(dateofbirth)).Date; //не работает
            DateOfBirth = dateofbirth;
            PlaceOfBirth = placeofbirth;
            Passport = passport;
        }

        //public override bool Equals(object obj)    //как бы перегружаем метод Equals()
        public bool Equals1(object pers)
        {
            if (pers == null) throw new ArgumentNullException("Нельзя сравнивать с null.");

            try
            {
                Person pers1 = pers as Person;
                return this.SurnameName == pers1.SurnameName &&
                       this.DateOfBirth == pers1.DateOfBirth &&
                       this.PlaceOfBirth == pers1.PlaceOfBirth &&
                       this.Passport == pers1.Passport;
            }
            catch
            {
                throw new ArgumentException("Объект для сравнения не относится к классу Person.");
            }
        }

        //public override int GetHashCode()     //как бы перегружаем метод GetHashCode()
        public int GetHashCode1()
        {
            return 12345678;
            //return SurnameName.GetHashCode() + DateOfBirth.GetHashCode() + PlaceOfBirth.GetHashCode() + Passport.GetHashCode();
        }

    }
}
