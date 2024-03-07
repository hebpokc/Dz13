using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dz13.Classes.NestedProperties;

namespace Dz13.Classes
{
    [Serializable]
    public class Student : Person
    {
        public Fullname Fullname { get; set; }
        public Birthday Birthday { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime RegistrationTime { get; set; }
        public Student() { }
        public Student(string name, string surname, string patronymic, int bday, int bmonth, int byear, Genders gender, string country, string city, int phoneNumber, DateTime registTime)
        {
            Fullname = new Fullname();
            Birthday = new Birthday();
            Fullname.name = name;
            Fullname.surname = surname;
            Fullname.patronymic = patronymic;
            Birthday.day = bday;
            Birthday.month = bmonth;
            Birthday.year = byear;
            Gender = gender;
            Country = country;
            City = city;
            PhoneNumber = phoneNumber;
            RegistrationTime = registTime;
        }
    }
}
