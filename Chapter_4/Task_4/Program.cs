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
            Console.WriteLine("Введите выполяемую арифметическую операцию");
            var operatorEnter = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите первый оператор => ");
            var operatorOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второй оператор => ");
            var operatorTwo = Convert.ToInt32(Console.ReadLine());

            switch (operatorEnter)
            {
                case "+":
                    Console.WriteLine("Операция сложение ");
                    Add(operatorOne,operatorTwo);
                    break;
                case "-":
                    Console.WriteLine("Операция вычетания ");
                    Sub(operatorOne, operatorTwo);
                    break;
                case "*":
                    Console.WriteLine($"Операция умножения ");
                    Mult(operatorOne, operatorTwo);
                    break;
                case "/":
                    Console.WriteLine($"Операция деление");
                    double opoperatorOneDoble = (double)operatorOne;
                    double opoperatorTwoDoble = (double)operatorTwo;
                    Division(opoperatorOneDoble, opoperatorTwoDoble);
                    
                    break;

                default:
                    Console.WriteLine("Такой операции нет ");
                    break;
            }
            Console.ReadKey();
        }

        public static void Add(int var1, int var2)
        {
            Console.WriteLine($"{var1} + {var2} = {var1+var2}");
        }
        public static void Sub(int var1, int var2)
        {
            Console.WriteLine($"{var1} - {var2} = {var1-var2}");
        }
        public static void Mult(int var1, int var2)
        {
            Console.WriteLine($"{var1} * {var2} = {var1*var2}");
        }
        public static void Division(double var1, double var2)
        {
            if (var1!=0 && var2!=0)
            {
                var result = var1 / var2;
                Console.WriteLine("{0:F3}", result); 
            }
            else
                Console.WriteLine("Деление на ноль ");
                
        }
    }
}
