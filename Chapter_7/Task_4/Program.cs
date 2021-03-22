using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(28,"Ivan","Ivanich","Математика");
            Student student2 = new Student(22,"Tom","Tomi","Физика");
            Student student3 = new Student(29,"Lent","lenti","Химия");
            Student student4 = new Student(24,"Opri","Opriya","Литература");
            Student student5 = new Student(99,"Old","Oldik","Физкультура");
            
            Student[] students = new Student[2];
            students[0] = student4;
            students[1] = student5;

            Student[] students1 = new Student[2];
            students1[0] = student3;
            students1[1] = student4;
            Teacher teacher = new Teacher(45,"Tolik","Tilinik",students);
            Teacher teacher1 = new Teacher(55,"Maga","Magadaga",students1);
            
            Person[] peoples = new Person[5];
            peoples[0] = student5;
            peoples[1] = student2;
            peoples[2] = teacher;
            peoples[3] = teacher1;
            peoples[4] = student1;

            PeopleInfo peopleInfo = new PeopleInfo(peoples);
            peopleInfo.AllPeoppleYear(peoples);

            Console.ReadKey();
            
        }
    }
}
