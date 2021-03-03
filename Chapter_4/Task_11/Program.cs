using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма вклада");
            var totalCash = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Введите сумму платежа");
                var amounеOfPayment = Convert.ToInt32(Console.ReadLine());
                
                LoanBalance(ref totalCash, amounеOfPayment);

                CashInfo(totalCash);
                if (totalCash <= 0)
                {
                    Console.WriteLine("Кредит выплачен");
                    break;
                }
            }
            Console.ReadKey();

        }

        static void CashInfo(int var) 
        {
            
            if (var<0)
            {
                Console.WriteLine($"Кредит составляет => {var}");
                
            }
            if (var>=0)
            {
                Console.WriteLine($"Кредит составляет => {var}");
            }
            
        }

        static void LoanBalance(ref int variable1, int variable2)
        {
            variable1 -= variable2;

            if (variable1 <= 0)
            {
                int temp = variable1;
                Console.WriteLine("Переплата по плетежу {0}", Math.Abs(temp));
            }

            //if (variable1 < variable2)
            //{
            //    Console.WriteLine("остаток платежа {0}", variable1);
            //}
         }
    }
}
