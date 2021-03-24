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
            DOCHandler dOCHandler = new DOCHandler();
            Console.WriteLine("Введите тип документа txt xml doc");

            string docoment = Convert.ToString(Console.ReadLine()); 
            
            switch (docoment)
            {
                case "txt":
                    tXTHandler.Change();
                    tXTHandler.Save();
                    tXTHandler.Open();
                    tXTHandler.Create();
                    break;
                case "xml":
                    xMLHabdler.Change();
                    xMLHabdler.Save();
                    xMLHabdler.Open();
                    xMLHabdler.Create();
                    break;
                case "doc":
                    dOCHandler.Change();
                    dOCHandler.Save();
                    dOCHandler.Open();
                    dOCHandler.Create();
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
