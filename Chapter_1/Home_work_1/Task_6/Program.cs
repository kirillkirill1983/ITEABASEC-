using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите скидку на продукт");
            var discountTotal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость товара");
            var productTotal = Convert.ToInt32(Console.ReadLine());

            var persent = (double)(discountTotal * productTotal) / 100;

            Console.WriteLine("Скидка составит {0}",persent );
            Console.ReadKey();
        }
    }
}
