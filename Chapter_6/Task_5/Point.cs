using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7
{
    class Point
    {
        private int pointX;
        private int pointY;
        private string name;

        public int PointX 
        {
            set { pointX = value; }
            get { return pointX; }
        }
        public int PointY 
        {
            set { pointY = value; }
            get { return pointY; }
        }
        public string Name 
        {
            set { name = value; }
            get { return name; }
        }
        public Point(int valueX, int valueY, string valuename)
        {
            pointX = valueX;
            pointY = valueY;
            name = valuename;
        }
    }
}
