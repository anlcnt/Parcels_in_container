using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTPAP.ClassesCore
{
    class Pointer
    {
        public Pointer(int minX, int minY, int maxX, int maxY)
        {
            MinX = minX;
            MinY = minY;
            MaxX = maxX;
            MaxY = maxY;
        }
        public Pointer()
        {
            MinX = 0;
            MinY = 0;
            MaxX = 0;
            MaxY = 0;
        }
        public int MinY { get; set; }
        public int MinX { get; set; }
        public int MaxY { get; set; }
        public int MaxX { get; set; }
    }
}
