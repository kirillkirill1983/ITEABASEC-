using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class DOCHandler:AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("DOC Change");
        }

        public override void Create()
        {
            Console.WriteLine("DOC Creat");
        }

        public override void Open()
        {
            Console.WriteLine("DOC Open");
        }

        public override void Save()
        {
            Console.WriteLine("DOC Save");
        }

    }
}
