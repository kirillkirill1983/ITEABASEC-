using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebbok notebbok = new Notebbok("Светлое", "Жигули", 20);

            notebbok.Display();

            Console.ReadKey();           
        }
    }
}
