using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class PeopleInfo
    {
        public Person[] PeopleArray { get; set; }
        public PeopleInfo(Person[] people)
        {
            this.PeopleArray = people;
        }

        public void AllPeoppleYear(Person[] person ) 
        {
            foreach (var item in PeopleArray)
            {
                Console.WriteLine($"{item.BirthYear} {item.Name}"); 
            }
            int tempB;
            string tempN;
            for (int i = 0;  i< PeopleArray.Length-1; i++)
            {
                for (int j = i+1; j < PeopleArray.Length; j++)
                {
                    if (person[i].BirthYear >person[j].BirthYear)
                    {
                        tempB = person[i].BirthYear;
                        tempN = person[i].Name;
                        person[i].BirthYear = person[j].BirthYear;
                        person[i].Name = person[j].Name;
                        person[j].BirthYear = tempB;
                        person[j].Name = tempN;
                        
                    }
                }
            }
           
            Console.WriteLine("========================");
            foreach (var item in PeopleArray)
            {
                Console.WriteLine($"{item.BirthYear} {item.Name}");
            }

        }

    }
}
