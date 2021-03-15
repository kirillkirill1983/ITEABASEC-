using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7
{
    class Figure
    {
        private Point[] points;
        public Point[] Points
        {
            set { points = value; }
            get { return points; }
        }
        public Figure(Point[] value) 
        {
            this.Points = value;
        } 
        public Figure(Point value1, Point value2, Point value3) 
        {
            this.Points = new Point[] { value1, value2, value3 };
        }

        public Figure(Point value1, Point value2, Point value3,Point value4)
        {
            this.Points = new Point[] { value1, value2, value3 ,value4};
        }

        public double Dlina(Point point1, Point point2) 
        {
            double result = Math.Sqrt((Math.Pow((point2.PointX - point1.PointX), 2) 
                + Math.Pow((point2.PointY - point1.PointY), 2)));
            return result;
        }
        
        public double Perimetr() 
        {
            double result = 0;
            //result = this.Dlina(points[0], points[1])+Dlina(points[1],points[2]);
            for (int i = 1; i < points.Length; i++)
            {
                {
                    result += this.Dlina(points[i-1], points[i]);

                }
            }
            return result;
        }
    }
}
