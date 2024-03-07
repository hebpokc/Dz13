using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz13.Classes.NestedProperties
{
    public class Fullname
    {
        public string name;
        public string surname;
        public string patronymic;
        public Fullname() { }
        public Fullname(string name, string surname, string patronymic)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
        }
    }
}
