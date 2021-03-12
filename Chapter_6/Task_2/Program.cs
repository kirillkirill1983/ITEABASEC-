using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "Темное";
            cat.Age = 1;
            cat.ColorCoat = "Светлое";
            cat.ColorEye = "Стекло";
            cat.BeepCat(3);
            Console.ReadKey();
        }
    }
}
