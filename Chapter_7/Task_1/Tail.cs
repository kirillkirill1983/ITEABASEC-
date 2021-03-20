using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Tail
    {
        private int length;
        private string type;

        public int Length 
        { get { return length; }
          set { length = value;}
        }

        public string Type 
        {
            get { return type; }
            set { type = value; }
        }

        public Tail(int valuelength, string valuetype)
        {
            length = valuelength;
            type = valuetype;
        }
    }
}
