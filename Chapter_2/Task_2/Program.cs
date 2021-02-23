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
            Console.WriteLine("Введите цену товара");
            int coastTotal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество купленого товара");
            int quantityGoos= Convert.ToInt32(Console.ReadLine());

            if (quantityGoos < 3)
            {
                double totalPrice = coastTotal * quantityGoos * 0.9;
                Console.WriteLine("Сумма покупки составила = {0}", totalPrice.ToString());

            }
            else if( quantityGoos>3 && quantityGoos<7)
                {
                double totalPrice = coastTotal * quantityGoos * 0.8;
                Console.WriteLine("Сумма покупки составила = {0}", totalPrice.ToString());
            }
            else 
                {
                double totalPrice = coastTotal * quantityGoos * 0.75;
                Console.WriteLine("Сумма покупки составила = {0}", totalPrice.ToString());
            }


            Console.ReadKey();
        }
    }
}
