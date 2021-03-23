using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class DocumentInfo:Document
    {
        public override void DocumentContent()
        {
            Console.WriteLine("DocumentContent");
        }

        public override void Footer()
        {
            Console.WriteLine("Foote");
        }

        public override void Headline()
        {
            Console.WriteLine("Headline");
        }
    }
}
