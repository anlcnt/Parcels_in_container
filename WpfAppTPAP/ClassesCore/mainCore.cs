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
