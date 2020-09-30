using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTPAP.ClassesCore
{
    class Box
    {
        public Box(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public Box(int width)
        {
            Width = width;
            Length = width;
        }

        public int Width { get; }
        public int Length { get; }

        public int Area => Width * Length;
        public int FormFactor => Length / Width;
    }
}
