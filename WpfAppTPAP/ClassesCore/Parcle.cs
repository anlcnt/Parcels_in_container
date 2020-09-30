using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTPAP.ClassesCore
{
    class Parcle : Box
    {
        public Parcle(int width, int length, int weight) : base(width, length)
        {
            Weight = weight;
        }

        public Parcle(int width, int weight) : base(width)
        {
            Weight = weight;
        }

        public void Vertical(int x, int y)
        {
            x0 = x; y0 = y;
            x2 = x + Width; y2 = y + Length;

            x1 = x; y1 = y + Length;
            x3 = x + Width; y3 = y;
        }
        public void Gorizontal(int x, int y)
        {
            x0 = x; y0 = y;
            x2 = x + Length; y2 = y + Width;

            x1 = x; y1 = y + Width;
            x3 = x + Length; y3 = y;
        }
        public int Weight { get; set; }

        public int x0 {get;set;}
        public int y0 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x3 { get; set; }
        public int y3 { get; set; }
    }
}
