using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    struct Train
    {
        public string destination;
        public int namberTraint;
        public DateTime dateTime;

        public Train(string sDestination,int sNamber,DateTime dateTime)
        {
            this.destination = sDestination;
            this.namberTraint = sNamber;
            this.dateTime = dateTime;
        }
        public override string ToString()
        {
            return String.Format($"{destination} {namberTraint} {dateTime} ");
        }

    }
}
