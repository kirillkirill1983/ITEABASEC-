using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Student:Person
    {
        private string studyCourse;
        public string StudyCourse
        {
            get { return studyCourse; }
            set { studyCourse = value; }
        }
        public Student(int bYear, string pName, string pSurname,string valueStudyCourse):base(bYear,pName, pSurname)
        {
            studyCourse = valueStudyCourse;
        }
        public void DisplayStudyCourse() 
        {
            Console.WriteLine($"{this.StudyCourse}");

        }

    }
}
