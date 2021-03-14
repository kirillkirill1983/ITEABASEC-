using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Figure
    {
        private Point[] points;
        public Point[]  Points
        {
            set { points = value; }
            get { return points; }
        }
        private string nameFigure;

        public Figure(Point point1, Point point2, Point point3)
        {
            this.points[0] = point1;
            this.points[1] = point2;
            this.points[2] = point3;
        }

        public Figure(Point point1, Point point2, Point point3,Point point4)
            :this(point1, point2,point3)
        {
            this.points[3] = point4;
        }

        public double Dlina(Point pointX1,Point pointx2) 
        {
            double result = Math.Sqrt((Math.Pow(2, pointx2.PontX-pointX1.PontX)+
                Math.Pow(2, pointx2.PontX - pointX1.PontX)));
            return result;
        }
    }
   
}
