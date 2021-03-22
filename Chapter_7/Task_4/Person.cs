using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Person
    {
        public int BirthYear { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(int bYear,string pName,string pSurname )
        {
            BirthYear = bYear;
            Name = pName;
            Surname = pSurname;
        }
    }
}
