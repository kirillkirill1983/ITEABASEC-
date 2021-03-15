using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 2, "F");
            Point point2 = new Point(3, 3, "r");
            Point point3 = new Point(6, 6, "r");
            Point point4 = new Point(8, 8, "r");
            Point point5 = new Point(9, 16, "fb");

            Point[] points = new Point[5];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;
            points[4] = point5;

            Figure figure = new Figure(point1, point2, point3,point4);
            Figure figure1 = new Figure(points);
            
            Console.WriteLine(string.Format("Длина между точками = {0:f}",figure.Dlina(point3,point4) ));

            Console.WriteLine(string.Format("Периметр без массива = {0:f}",figure.Perimetr()));

            Console.WriteLine(string.Format("Периметр массив = {0:f}",figure1.Perimetr()));

            Console.ReadKey();
        }
    }
}