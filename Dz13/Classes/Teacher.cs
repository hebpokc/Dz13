using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dz13.Classes.NestedProperties;

namespace Dz13.Classes
{
    public enum Skills
    {
        Любитель = 1,
        Профессионал,
        Мастер
    }
    [Serializable]
    public class Teacher : Person
    {
        public Fullname Fullname { get; set; }
        public Birthday Birthday { get; set; }
        public Skills Skill { get; set; }
        public string CourseName { get; set; }
        public List<Student> Students { get; set; }
        public Teacher() { }
        public Teacher(string name, string surname, string patronymic, int bday, int bmonth, int byear, Genders gender, string country, string city, Skills skill, string courseName)
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
            Skill = skill;
            Students = new List<Student>();
        }
    }
}
