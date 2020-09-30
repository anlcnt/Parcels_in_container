using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTPAP.ClassesCore
{
    class mainCore
    {
        List<Parcle> Parcles = new List<Parcle>();
        Container Container;
        bool Method;

        public mainCore(List<Parcle> parcles, Container container, bool method)
        {
            Container = container;
            Parcles = parcles;
            Method = method;
        }

        void BruteForce()
        {
            if(Method)
            {
                
            }
            else
            {

            }
        }
    }
}
