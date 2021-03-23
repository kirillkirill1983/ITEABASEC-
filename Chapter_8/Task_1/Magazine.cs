using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Magazine : IPrintable
    {
        public IPrintable[] printable { get; set; }

        public void print()
        {
            Console.WriteLine("Магазин");

        }

        public void printMagazine(IPrintable[] printables) 
        {
            for (int i = 0; i < printables.Length; i++)
            {
                if (printables[i] is Journal)
                {
                    printables[i].print();
                } 
                
            }
        }
    }
}
