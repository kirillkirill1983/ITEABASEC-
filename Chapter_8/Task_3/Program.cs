﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentInfo documentInfo = new DocumentInfo();
            documentInfo.Headline();
            documentInfo.DocumentContent();
            documentInfo.Footer();

            documentInfo.Virtual();

            Console.ReadKey();
        }
    }
}
