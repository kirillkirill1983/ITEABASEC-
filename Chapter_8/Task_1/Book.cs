using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Book : IPrintable
    {
        public IPrintable[] printable { get; set; }

        public void print()
        {
            Console.WriteLine("Отличная книга"); 
        }

        public void printBooks(IPrintable[] printables)
        {
            for (int i = 0; i < printables.Length; i++)
            {
                if (printables[i] is Book )
                {
                    printables[i].print();
                }

            }
        }
    }
}
