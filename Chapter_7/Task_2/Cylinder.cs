using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Cylinder:Shape
    {
        public int Radius { get; set; }
        public int Height { get; set; }

        public Cylinder(int radius,int height)
        {
            Radius = radius;
            Height = height;
        }
        
        public new double GetVolume() 
        {
            return (0.33 * 3.14 * Height * Math.Pow(Radius, 2));
            
        }

    }
}
