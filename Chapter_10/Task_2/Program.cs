using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Train train1 = new Train("poinA", 1, 10);
            //Train train2 = new Train("PoinB", 2, 11);
            //Train train3 = new Train("Poinc", 2, 11);

            //Train[] arrayTrain = new Train[] { train1, train2, train3 };
            Train[] arrayTrain = new Train[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите конечную точку => ");
                string endStation = Convert.ToString(Console.ReadLine());
                arrayTrain[i].destination = endStation;
                arrayTrain[i].namberTraint = i;
                arrayTrain[i].dateTime = new DateTime();
                
            }

            foreach (var item in arrayTrain)
            {
                Console.WriteLine(item);
            }
            Console.Write("введите номер поезда=>");
            int namber = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arrayTrain.Length; i++)
            {
                if (arrayTrain[i].namberTraint==namber)
                {
                    Console.WriteLine($"{arrayTrain[i].namberTraint }  {arrayTrain[i].dateTime }" );
                }
               
            }

            Console.ReadKey();
        }
    }
}
