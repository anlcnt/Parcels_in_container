using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTPAP.ClassesCore
{
    class mainCore
    {
        List<Parcle> parcles = new List<Parcle>();
        Container Container;

        public mainCore(List<Parcle> parcles, Container container)
        {
            Container = container;
            this.parcles = parcles;
        }


    }
}
