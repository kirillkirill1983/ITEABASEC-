using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Triangle
    {
        private int siteOne;
        private int siteTwo;
        private int siteThree;

        public int SiteOne
        {
            set { siteOne = value; }
            get { return siteOne; }
        }
        public int SiteTwo
        {
            set { siteTwo = value; }
            get { return siteTwo; }
        }
        public int SitrThree
        {
            set { siteThree = value; }
            get { return siteThree; }
        }

        public Triangle(int valueOne, int valueTwo, int valueThree)
        {
            siteOne = valueOne;
            siteTwo = valueTwo;
            siteThree = valueThree;
        }

        public void Square()
        {
            double semiPerimeter = (SiteOne + SiteTwo + SitrThree) / 2;
            double squareTotal = Math.Sqrt(semiPerimeter * (semiPerimeter - SiteOne) *
                (semiPerimeter - SiteTwo) * (semiPerimeter - SitrThree));

            Console.WriteLine(String.Format("Площадь треугольника =>> {0:f}", squareTotal));
        }
        public void Perrimetr()
        {
            double perimeter = (SiteOne + SiteTwo + SitrThree) / 2;
            Console.WriteLine(String.Format("Периметр треугольника =>> {0:f}", perimeter));

        }
        public void  Total() 
        {
           Console.WriteLine("===============");
           this.Square();
           this.Perrimetr(); 
        }

    }
}
