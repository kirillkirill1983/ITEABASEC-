using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Ball:Shape
    {
        
        public int Radius { get; set; }
       

        public Ball(double vVolume, int radius ):base(vVolume)
        {

            this.Radius = radius;
        }

        public new double GetVolume() 
        {
            return (1.33 * 3.14*Math.Pow(Radius,2));
        }
    }
}
