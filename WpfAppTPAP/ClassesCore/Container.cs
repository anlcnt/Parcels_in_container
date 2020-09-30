using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTPAP.ClassesCore
{
    class Container
    {
        public Container(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Container(int width)
        {
            Width = width;
            Height = width;
        }

        public int Width { get; }
        public int Height { get; }
    }
}
