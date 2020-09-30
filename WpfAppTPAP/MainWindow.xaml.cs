using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppTPAP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.count_parcles.PreviewTextInput += new TextCompositionEventHandler(textBox_PreviewTextInput);
        }
        void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //if (!Char.IsDigit(e.Text, 0) || (sender as TextBox).Text.Length >= _inputValue.Length || e.Text != _inputValue)
            //e.Handled = true;
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void Sumbit_Click(object sender, RoutedEventArgs e)
        {
            //DG_Parcles
        }

        private void Exit_Click(object sender, RoutedEventArgs e) => Close();
    }

}
