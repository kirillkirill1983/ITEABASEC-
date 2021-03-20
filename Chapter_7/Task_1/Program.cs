using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tail tail = new Tail(10, "Длинный");
            Dog dog = new Dog(tail, "green", 10, "Serono");
            Dog dogBad = new Dog(tail,"серый",12,"Сеня");
            dog.Info();
            dogBad.Info();
            dog.Tail = new Tail(13, "короткий");
            Console.WriteLine(dog.GetType());
            dog.Info();
            Console.ReadKey();
        }
    }
}
