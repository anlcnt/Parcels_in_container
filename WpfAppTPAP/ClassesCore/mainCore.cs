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


        void BruteForce()
        {
            if(!Method)
            {
                Pointer[] CoordsSystem = new Pointer[2] { new Pointer(0, 0), new Pointer(0, 0) };

                foreach (Parcle item in Parcles)
                {
                    foreach (Pointer coords in CoordsSystem)
                    {
                        item.Vertical(coords.X, coords.Y);
                        if (item.x0 == coords.X && item.x1 == coords.X &&
                            item.y0 == coords.Y && item.y3 == coords.Y)
                        {
                            //счет коэф
                            //запоминаем минимум
                        }

                        item.Gorizontal(coords.X, coords.Y);
                        if (item.x0 == coords.X && item.x1 == coords.X &&
                            item.y0 == coords.Y && item.y3 == coords.Y)
                        {
                            //счет коэф
                        }
                    }
                }
                

            }
            else
            {

            }
        }
    }
}
