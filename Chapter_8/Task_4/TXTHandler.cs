using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("TXT Change");
        }

        public override void Create()
        {
            Console.WriteLine("TXT Creat");
        }

        public override void Open()
        {
            Console.WriteLine("TXT Open");
        }

        public override void Save()
        {
            Console.WriteLine(" TXT Save");
        }
    }
}
