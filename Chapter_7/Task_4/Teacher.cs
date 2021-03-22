using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Teacher:Person
    {
        public Student[] StudentsArray { get; set; }
        public Teacher(int bYear, string pName, string pSurname,Student[] students): base(bYear, pName, pSurname)
        {
            this.StudentsArray = students;
        }
        //public Teacher(int bYear, string pName, string pSurname,Student studentone,Student studentTwo):base(bYear, pName, pSurname)
        //{
        //    this.StudentsArray[0] = studentone;
        //    this.StudentsArray[1] = studentTwo;
        //}
    }
}
