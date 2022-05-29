﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using HHLibrary;


namespace HHBotWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string vacUrl = "http://api.hh.ru/vacancies?text=";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            ResListBox.Items.Clear();
            HHModel m = new HHModel();
            string tmpRes = m.RequestGet(vacUrl + textBox.Text);
            List<Vacancy> v = m.JsonParseStringItems(tmpRes);

            foreach (Vacancy vacancy in v)
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = vacancy.id + " " + vacancy.name;
                item.Tag = vacancy.info;

                ResListBox.Items.Add(item);

            }
        }

        private void infoButton_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem item = (ListBoxItem)ResListBox.SelectedItem;
            if (item != null)
            {
                //MessageBox.Show(item.Tag.ToString());
                Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\Chrome.exe", item.Tag.ToString());
            }
        }
    }
}
