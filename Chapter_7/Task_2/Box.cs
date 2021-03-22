using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Box
    {
        private double drawerVolume;
        public double DrawerVolume
        {
            get { return drawerVolume; }
            set { drawerVolume = value; }
        }
        public Box(double drawerVolume)
        {
            this.drawerVolume = drawerVolume;
        }

        public bool Add(Shape shape) 
        {

            if (shape is Ball )
            {
                Ball ball = (Ball)shape;
                if (ball.GetVolume() < DrawerVolume)
                {
                    DrawerVolume -= ball.GetVolume();
                    return true;
                }
                else { return false; }
                    
            }
            else if (shape is Cylinder)
            {
                Cylinder cylinder = (Cylinder)shape;
                DrawerVolume -= cylinder.GetVolume();
                return true;

            }
            else if (shape is Pyramid)
            {
                Pyramid pyramid = (Pyramid)shape;
                DrawerVolume -= pyramid.GetVolume();
                return true;

            }
            else
                return false;
        }
    }
}
