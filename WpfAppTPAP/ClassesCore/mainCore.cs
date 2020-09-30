using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppTPAP.ClassesCore
{
    class mainCore
    {
        List<Parcle> Parcles = new List<Parcle>();
        Container Container;
        bool Method;
        int Count;
        //ItemCollection objDataGrid;

        public mainCore(Container container, bool method, ItemCollection objDG)
        {            
            foreach (Parcle parcle in objDG)
            {
                //LB_res.Items.Add(Convert.ToString(parcle.Width) + ' ' + Convert.ToString(parcle.Length) + ' ' + Convert.ToString(parcle.Weight));
                Parcles.Add(new Parcle(parcle.Width, parcle.Length, parcle.Weight));
            }

            //Parcles = parcles;
            Method = method;
            Container = container;
            Count = objDG.Count;
        }

        void FromBigToLit()
        {
            List<Parcle> p = new List<Parcle>();

            int i = 0;
            foreach (Parcle item in Parcles)
            {
                int count = i;
                int AreaMax = item.GetArea();

                int j = 0;
                foreach (Parcle itemIns in Parcles)
                {
                    if (AreaMax < itemIns.GetArea())
                    {
                        count = j;
                        AreaMax = itemIns.GetArea();
                    }
                    j++;
                }

                p.Add(Parcles[count]);
                Parcles.RemoveAt(count);
                i++;
            }
        }

        void BruteForce()
        {
            if(!Method)
            {
                Pointer CoordsSystem = new Pointer();


            }
            else
            {

            }
        }
    }
}
