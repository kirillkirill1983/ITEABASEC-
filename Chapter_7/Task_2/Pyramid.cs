using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Pyramid:Shape
    {
        public int Height { get; set; }
        public int Side { get; set; }

        public Pyramid(int height,int side)
        {
            Height =height ;
            Side = side; 
        }

        public new double GetVolume()
        {
            double result= (0.33 * Height * Math.Pow(Side, 2));
            return result;
            
        }
    }
}
