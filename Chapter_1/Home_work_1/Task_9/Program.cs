using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI=3.14f;

            Console.WriteLine("Введите радиус цилиндра r");
            var radiusСylinder = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите высоту цилиндра h");
            var cylinderHeight= Convert.ToInt32(Console.ReadLine());

            var volumeCylinder = PI * Math.Pow(radiusСylinder, 2) * cylinderHeight;

            var squareCylinder = (double)(2 * PI * radiusСylinder*(radiusСylinder + cylinderHeight));

            Console.WriteLine("V = {0}, S= {1}",volumeCylinder,squareCylinder);

            Console.ReadKey();

        }
    }
}
