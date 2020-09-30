using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTPAP.ClassesCore
{
    class Container : Box
    {
                
        public Container(int width, int length) : base(width, length)
        {

        }

        public Container(int width) : base(width)
        {

        }

        public int GetFreeSpaceAspectRatio()
        {
            return 0;
        }
    }
}
