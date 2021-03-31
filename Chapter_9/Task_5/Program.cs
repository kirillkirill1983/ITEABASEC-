using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            PointXYZ pointXYZ1 = new PointXYZ(2, 4, 7);
            PointXYZ pointXYZ2 = new PointXYZ(4, 6, 7);
            

            Console.WriteLine($"{ pointXYZ1} +{pointXYZ2} ={pointXYZ1+pointXYZ2}"+"\n");
            Console.WriteLine($"{ pointXYZ1} -{pointXYZ2} ={pointXYZ1 - pointXYZ2}"+"\n");
            Console.WriteLine($"{ pointXYZ1} *{pointXYZ2} ={pointXYZ1 * pointXYZ2}"+"\n");
            Console.WriteLine($"{pointXYZ1} /{pointXYZ2} ={pointXYZ1 / pointXYZ2}"+"\n");
            Console.WriteLine($"{pointXYZ1.Equals(pointXYZ2)}");
            Console.WriteLine($"HASH {pointXYZ1} = {pointXYZ1.GetHashCode()}");
            Console.WriteLine($"HASH {pointXYZ2} = {pointXYZ2.GetHashCode()}");
            Console.ReadKey();
        }
    }
}
