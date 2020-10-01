using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTPAP.ClassesCore
{
    public class Box
    {
        public Box(int width, int length)
        {
            if (width == 0) width = 1;
            if (length == 0) length = 1;
            if (width > length)
            {
                Width = length;
                Length = width;
            }
            else
            {
                Width = width;
                Length = length;
            }
        }

        public Box(int width)
        {
            if (width == 0) width = 1;
            Width = width;
            Length = width;
        }

        public int Width { get; set; }
        public int Length { get; set; }

        // Возвращает площадь объекта
        public int GetArea() => Width * Length;
        // Возвращает коэффициент формы
        public int GetFormFactor() => Length / Width;
    }
}
