using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dz13.Classes.NestedProperties;

namespace Dz13.Classes
{
    public enum Genders
    {
        Мужской,
        Женский
    }
    [Serializable]
    public class Person
    {
        public Fullname FullName { get; set; }
        public Birthday BirthDay { get; set; }
        public Genders Gender { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public Person() { }
        public Person(string name, string surname, string patronymic, int bday, int bmonth, int byear, Genders gender, string country, string city) 
        {
            FullName.name = name;
            FullName.surname = surname;
            FullName.patronymic = patronymic;
            BirthDay.day = bday;
            BirthDay.month = bmonth;
            BirthDay.year = byear;
            Gender = gender;
            Country = country;
            City = city;
        }
    }
}
