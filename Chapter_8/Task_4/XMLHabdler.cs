﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class XMLHabdler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("XML Change");
        }

        public override void Create()
        {
            Console.WriteLine("XML Create");
        }

        public override void Open()
        {
            Console.WriteLine("XML Open");
        }

        public override void Save()
        {
            Console.WriteLine("XML Save");
        }
    }
}
