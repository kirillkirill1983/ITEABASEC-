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
            Console.Write("введите сумму вклада=> ");
            var emountEnter = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Введите процентную ставку=> ");
            var interestRate = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите срок =>");
            var timeTotal = Convert.ToInt32(Console.ReadLine());

            var totalMoney = (emountEnter * interestRate) / 100;
            
            int Money = 0;
            
            for (int i = 0; i < timeTotal; i++)
            {
                Money += totalMoney;
            }

            Console.WriteLine("Сумма процентов {0}",Money);

            Console.ReadKey();
        }
    }
}
