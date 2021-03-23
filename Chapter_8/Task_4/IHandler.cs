using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public interface IHandler
    {
        void Open();
        void Create();
        void Change();
        void Save();
    }
}
