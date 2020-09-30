using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTPAP.ClassesCore
{
    class Container
    {
        public Container(int width, int length, List<Parcle> parcles)
        {
            Width = width;
            Length = length;
            Parcles = parcles;
        }

        public Container(int width, List<Parcle> parcles)
        {
            Width = width;
            Length = width;
            Parcles = parcles;
        }

        public Container(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public Container(int width)
        {
            Width = width;
            Length = width;
        }

        public int Width { get; }
        public int Length { get; }
        public List<Parcle> Parcles { get; set; }

        public int Area => Width * Length;
        public int FormFactor => Length / Width;
    }
}
