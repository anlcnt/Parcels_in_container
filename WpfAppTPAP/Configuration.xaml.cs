using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAppTPAP.ClassesCore;

namespace WpfAppTPAP
{
    /// <summary>
    /// Логика взаимодействия для Configuration.xaml
    /// </summary>
    public partial class Configuration : Window
    {
        /*public Container CurrentContainer { get; set; }
        private int ContainerWidth
        {
            get => Convert.ToInt32(textBoxWidth.Text);
            set => textBoxWidth.Text = Convert.ToString(value);
        }
        private int ContainerLength
        {
            get => Convert.ToInt32(textBoxLength.Text);
            set => textBoxLength.Text = Convert.ToString(value);
        }*/
        //private Container Container { get; set; }

        public Configuration(List<Parcle> parcles, Container container,bool method)
        {
            Container x = new Container(1, 1);
            /*ContainerWidth = CurrentContainer.Width;
            ContainerLength = CurrentContainer.Length;*/

            InitializeComponent();
            //WpfAppTPAP.ClassesCore.Container container = x;
            TB_cnt_lenght.Text = Convert.ToString(container.Length);
            TB_cnt_wight.Text = Convert.ToString(container.Width);
        }


    }
}
