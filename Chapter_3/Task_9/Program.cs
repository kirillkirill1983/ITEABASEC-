using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число ");
            var oneNamber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число ");
            var twoNamber = Convert.ToInt32(Console.ReadLine());
            
            

            if (oneNamber>twoNamber)
            {
                int sum=0;
                Console.WriteLine("Значение 1>2");
                
                for (int i = twoNamber; i < oneNamber; i++)
                {
                    sum += i;

                }
                Console.WriteLine("Сумма промежутка равна {0}",sum);
            }

            if (oneNamber < twoNamber)
            {
                
                Console.WriteLine("Значение 1<2");

                for (int i = oneNamber; i < twoNamber; i++)
                {
                    if (i%2!=0)
                    {
                        Console.WriteLine($"Число {i} ");
                    }
                }
             }

            Console.ReadKey();
        }
    }
}
