using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTPAP.ClassesCore
{
    class Pointer
    {
        public Pointer(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Pointer()
        {
            X = 0;
            Y = 0;
        }
        public int Y { get; set; }
        public int X { get; set; }
    }
}
