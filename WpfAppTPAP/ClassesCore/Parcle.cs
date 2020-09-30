using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTPAP.ClassesCore
{
    class Parcle
    {
        public Parcle(int width, int length, int weight)
        {
            Width = width;
            Length = length;
            Weight = weight;
        }

        public Parcle(int width, int weight)
        {
            Width = width;
            Length = width;
            Weight = weight;
        }

        public int Width { get; }
        public int Length { get; }
        public int Weight { get; }

        public int Area => Width * Length;
        public int FormFactor => Length / Width;
    }
}
