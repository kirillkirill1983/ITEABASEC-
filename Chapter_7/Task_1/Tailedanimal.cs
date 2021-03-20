using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Tailedanimal
    {
        private Tail tail;
        private string color;
        private int age;

        public Tail Tail
        {
            get { return tail; }
            set { tail = value; }
        }

        public string Color 
        {
            get { return color; }
            set { color = value; }
        }
        public int Age 
        {
            get { return age; }
            set { age = value; }
        }
        public Tailedanimal(Tail valuetail,string valuecolor,int valueage)
        {
            tail = valuetail;
            color = valuecolor;
            age = valueage;
        }

    }
}
