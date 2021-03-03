using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите cумму для обмена => ");
            var operatorOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите курс Валют с точностью до копейки(27.8)=> ");
            var operatorTwo = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Сумма на ПИВАС =>>>>");
            
            
            Exchange(operatorOne, operatorTwo);

            Console.ReadKey();
        }

        public static void Exchange(int var1, double var2)
        {
            if (var1 != 0 && var2 != 0)
            {
                var result = var1 * var2;
                Console.WriteLine("{0:F3}", result);
            }
            else
                Console.WriteLine("Без пивася((( ");

        }
    }
}
