using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball(500,10);
            Cylinder cylinder = new Cylinder(500,10, 12);
            Pyramid pyramid = new Pyramid(600,15, 4);
            Console.WriteLine("Объем шара => {0}", ball.GetVolume().ToString());
            Console.WriteLine("Объем  цилиндра => {0}",cylinder.GetVolume().ToString());
            Console.WriteLine("Объем пирамиды  => {0}",pyramid.GetVolume().ToString());
            
            Box box = new Box(1400);
            Console.WriteLine("Обем корзины {0}",box.DrawerVolume.ToString());
            
            while (true)
            {
                Console.WriteLine("Введите для выхода No продолжить Enter");
                string exit = Convert.ToString(Console.ReadLine());
                if (exit=="No")
                {
                    break;
                }
                Console.WriteLine("Что добавить в корзину 1-шар 2- Цилинда 3-Пирамида");
                string shape = Convert.ToString(Console.ReadLine());
                switch (shape)
                {
                    case "1":
                        bool flag = box.Add(ball);
                        if (flag==false)
                        {
                            Console.WriteLine("Корзина полна");
                            goto Finish;
                            
                        }
                        Console.WriteLine(box.DrawerVolume.ToString());
                        break;
                    
                    case "2":
                        bool flag1 = box.Add(cylinder);
                        if (flag1 == false)
                        {
                            Console.WriteLine("Корзина полна");
                            goto Finish;
                        }
                        Console.WriteLine(box.DrawerVolume.ToString());
                        break;

                    case "3":
                        bool flag3 = box.Add(pyramid);
                        if (flag3 == false)
                        {
                            Console.WriteLine("Корзина полна");
                            goto Finish;
                        }
                        Console.WriteLine(box.DrawerVolume.ToString());
                        break;

                    default:
                        break;
                }
            }
            Finish:
            Console.WriteLine( "Конец");

            //Console.WriteLine(box.DrawerVolume.ToString());
            //Console.WriteLine(box.Add(ball).ToString());
            //Console.WriteLine(box.DrawerVolume.ToString());

            //Console.WriteLine(cylinder.GetVolume().ToString());
            //Console.WriteLine(box.DrawerVolume.ToString());
            //Console.WriteLine(box.Add(ball).ToString());
            //Console.WriteLine(box.DrawerVolume.ToString());


            Console.ReadKey();

             
        }
    }
}
