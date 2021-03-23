﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public abstract class AbstractHandler : IHandler
    {
        public abstract void Change();
        public abstract void Create();
        public abstract void Open();
        public abstract void Save();
    }
}
