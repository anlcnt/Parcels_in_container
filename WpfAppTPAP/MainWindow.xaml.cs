﻿using System;
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
using WpfAppTPAP.ClassesCore;

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
            this.TB_length_cnt.PreviewTextInput += new TextCompositionEventHandler(textBox_PreviewTextInput);
            this.TB_wigth_cnt.PreviewTextInput += new TextCompositionEventHandler(textBox_PreviewTextInput);
            grid_Loaded(Convert.ToInt32(count_parcles.Text));
        }
        void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //if (!Char.IsDigit(e.Text, 0) || (sender as TextBox).Text.Length >= _inputValue.Length || e.Text != _inputValue)
            //e.Handled = true;
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void Sumbit_Click(object sender, RoutedEventArgs e)
        {
            if (DG_Parcles.Items.Count != 0)
            {//запоминаем все посылки
                List<Parcle> parcles = new List<Parcle>();

                LB_res.Items.Clear();
                foreach (Parcle parcle in DG_Parcles.Items)
                {
                    //LB_res.Items.Add(Convert.ToString(parcle.Width) + ' ' + Convert.ToString(parcle.Length) + ' ' + Convert.ToString(parcle.Weight));
                    parcles.Add(new Parcle(parcle.Width, parcle.Length, parcle.Weight));
                }

                List<Parcle> p = new List<Parcle>();
                int length = parcles.Count;
                for (int i = 0; i < length; i++)
                {

                    int count = i;
                    int AreaMax = parcles[i].GetArea();

                    int j = 0;
                    foreach (Parcle itemIns in parcles)
                    {
                        if (AreaMax < itemIns.GetArea())
                        {
                            count = j;
                            AreaMax = itemIns.GetArea();
                        }
                        j++;
                    }

                    p.Add(parcles[count]);
                    parcles.RemoveAt(count);
                    i--;
                    length--;
                    //
                }

                foreach (Parcle parcle in p)
                {
                    LB_res.Items.Add(Convert.ToString(parcle.Width) + ' ' + Convert.ToString(parcle.Length) + ' ' + Convert.ToString(parcle.Weight));
                    //parcles.Add(new Parcle(parcle.Width, parcle.Length, parcle.Weight));
                }

                var obj = DG_Parcles.Items;


                //запомиинаем контейнеры
                Container container = new Container(Convert.ToInt32(TB_wigth_cnt.Text), Convert.ToInt32(TB_length_cnt.Text));
            }
            else MessageBox.Show("Задайте значения посылок");
        }

        private void Exit_Click(object sender, RoutedEventArgs e) => Close();

        private void grid_Loaded(int count)
        {
            List<Parcle> result = new List<Parcle>();

            for(int i=0; i<count;i++)
            {
                Parcle currentParcle = new Parcle(100, 100, 1);
                result.Add(currentParcle);
            }
            DG_Parcles.ItemsSource = result;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            grid_Loaded(Convert.ToInt32(count_parcles.Text));
        }

        private void DG_Parcles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    

}
