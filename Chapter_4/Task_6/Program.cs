using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите первый оператор => ");
            var operatorOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второй оператор => ");
            var operatorTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третий оператор => ");
            var operatoThre = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($" Первый = {operatorOne} Второй = {operatorTwo} Третий = {operatoThre}");

            
            MethodRef(ref operatorOne,ref operatorTwo, ref operatoThre);
            Console.WriteLine($" Первый = {operatorOne} Второй = {operatorTwo} Третий = {operatoThre}");

            Console.WriteLine("MethodOut");

            MethodOut(operatorOne, operatorTwo, operatoThre, out int var1, out int var2, out int var3);
            Console.WriteLine($" Первый = {var1} Второй = {var2} Третий = {var3}");

            Console.ReadKey();
        }

        public static void MethodRef(ref int variable1, ref int variable2, ref int variable3)
        {
            variable1 *= 10;
            variable2 *= 10;
            variable3 *= 10;
        }

        public static void MethodOut(int par1,int par2, int par3, out int variablel1, out int variable2, out int variable3)
        {
            variablel1 = par1 * 10;
            variable2 = par2 * 10;
            variable3 = par3 * 10;
        }
    } 
}
