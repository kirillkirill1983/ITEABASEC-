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
            Console.WriteLine("Сколько у тебя денег обжора? 0_0");
            var moneyTotal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько стоит это холодное вещество?");
            var moneyIce = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            
            while (moneyTotal>0)
            {
                moneyTotal -= moneyIce;
                i++;
                if (moneyTotal<moneyIce)
                    break;

            }

            Console.WriteLine($"{i}");

            Console.ReadKey();
                
        }
    }
}
