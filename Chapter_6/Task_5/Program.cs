﻿using System;
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
            Point pointA = new Point(1,1,"rectang");
            Point pointB = new Point(1,1, "rectang");
            Point pointC = new Point(3,1, "rectang");

            Point[] points = new Point[3];
            points[0] = pointA;
            points[0] = pointB;
            points[0] = pointC;
            //Figure figure = new Figure(pointA,pointB,pointC);

            Figure figure = new Figure(points);

            var result = figure.Dlina(pointA, pointB);
            
            Console.WriteLine(String.Format("=>> {0:f}", result));

            var perimetr = figure.Perimetr();
            Console.WriteLine(String.Format("=>> {0:f}", perimetr));
            Console.ReadKey();
        }
    }
}

