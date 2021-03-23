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
            TXTHandler tXTHandler = new TXTHandler();
            XMLHabdler xMLHabdler = new XMLHabdler();
            string docoment = Convert.ToString(Console.ReadLine()); 
            switch (docoment)
            {
                case "txt":
                    tXTHandler.Change();
                    break;
                case "xml":
                    xMLHabdler.Change();
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
