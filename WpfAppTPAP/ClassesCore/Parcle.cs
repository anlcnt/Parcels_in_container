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

        public int Weight { get; }

    }
}
