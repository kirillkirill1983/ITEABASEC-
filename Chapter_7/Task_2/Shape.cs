using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Shape
    {
        private double volume;
        public double Volume 
        {
            get { return volume; }
            set { volume = value; }
        }
        
        public double GetVolume() 
        {
            return Volume;
        }
    }
}
