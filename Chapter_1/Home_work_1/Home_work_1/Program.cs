using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите метры: ");
            int metrTotal = Convert.ToInt32(Console.ReadLine());
            //int meterTotal = centimeterTotal + 1000;
            Console.WriteLine($"Метры {metrTotal} это будет {metrTotal *1000} сантиметров");
            Console.ReadKey();
        }
    }
}
