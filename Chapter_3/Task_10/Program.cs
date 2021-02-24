using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                Console.Write("Введите первое число => ");
                var oneNamber = Convert.ToInt32(Console.ReadLine());

                lanel1:
                Console.Write("Введите второе число=> ");
                var twoNamber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите знак операции => ");
                var operationSign_ = Convert.ToChar(Console.ReadLine());
                
                if (operationSign_=='0')
                {
                    break;
                }
                switch (operationSign_)
                {
                    case '+':
                        Console.WriteLine($"{oneNamber} + {twoNamber} ={oneNamber+twoNamber}");
                        break;

                    case '-':
                        Console.WriteLine($"{oneNamber} - {twoNamber} ={oneNamber - twoNamber}");
                        break;

                    case '*':
                        Console.WriteLine($"{oneNamber} * {twoNamber} ={oneNamber * twoNamber}");
                        break;

                    case '/':
                        if (twoNamber==0)
                        {
                            Console.WriteLine("Делить на ноль нельзя ");
                            goto lanel1;
                        }
                        Console.WriteLine($"{oneNamber} / {twoNamber} ={oneNamber/twoNamber}");
                        break;

                    default:
                        Console.WriteLine("ввели неверное значение");
                        break;
                }

            }
            Console.WriteLine("end");
            Console.ReadKey();
        }
    }
}
