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
            Console.WriteLine("введите сумму вклада");
            var emountEnter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Введите процентную ставку");
            var interestRate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите срок");
            var timeTotal = Convert.ToInt32(Console.ReadLine());
        }
    }
}
