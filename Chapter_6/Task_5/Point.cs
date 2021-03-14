using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Point
    {
        private int pointX;
        private int pointY;
        private string namePoint;
        
        public int PontX 
        {
            set { pointX = value; }
            get { return pointX; }
        }
        public int PointY 
        {
            set { pointY = value; }
            get { return pointY; }
        }
        public string NamePoint 
        {
            set { namePoint = value; }
            get { return namePoint; }
        }

        public Point(int valueX, int valueY, string name) 
        {
            pointX = valueX;
            pointY = valueY;
            namePoint = name;
        }
    }
}
