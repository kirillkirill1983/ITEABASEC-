using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону прямоугольника");
            var sideOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону прямоугольника");
            var sideTwo = Convert.ToInt32(Console.ReadLine());

            Perimetr(sideOne, sideTwo, out double perimetr, out double area);
            Console.WriteLine($" Периметр = {perimetr}, Площадь = {area}");

            Console.ReadKey();
        }
        public static void Perimetr(int var1, int var2, out double per, out double area)
        {
            per = 2 * (var1 + var2);
            area = (var1 * var2);
        }
    }
}
