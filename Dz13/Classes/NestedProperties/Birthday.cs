using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz13.Classes.NestedProperties
{
    public class Birthday
    {
        public int day;
        public int month;
        public int year;
        public Birthday() { }
        public Birthday(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
    }
}
