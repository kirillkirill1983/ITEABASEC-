using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(10, 10, 10);
            triangle.Square();
            triangle.Perrimetr();
            triangle.Total();
            Console.ReadKey();
        }
    }
}
