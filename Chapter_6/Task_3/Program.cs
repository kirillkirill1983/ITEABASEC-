using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(new DateTime(2021, 2, 1, 0,0,0), 30.0,10000);
            bankAccount.NumberOfDays(DateTime.Now);
            bankAccount.DepositAmount(3);
            Console.ReadKey();
        }
    }
}
