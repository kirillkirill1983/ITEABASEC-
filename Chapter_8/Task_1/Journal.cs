using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Journal : IPrintable
    {
        public void print()
        {
            Console.WriteLine("Отличный журнал");
        }
    }
}
