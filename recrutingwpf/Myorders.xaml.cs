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

namespace recrutingwpf
{
    /// <summary>
    /// Логика взаимодействия для Myorders.xaml
    /// </summary>
    public partial class Myorders : Page
    {
        public static Frame Frame { get; set; }
        int Id;
        public Myorders(int id)
        {
            InitializeComponent();
            var currentOrders = RecrutContext.GetContext().orders.Where(p => p.hirerid  == id).ToList(); ;
            ListImage.ItemsSource = currentOrders;
            Id= id;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Global.glavWin.mainFrame.Navigate(new NewOrder());
        }

        private void ListImage_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (ListImage.SelectedItem != null)
            {
                Order order= ListImage.SelectedItem as Order;
                if (order.id == 0)
                {
                    Global.glavWin.mainFrame.Navigate(new NewOrder(order.id));



                    RecrutContext.GetContext().SaveChanges();
                    MessageBox.Show("Отклик удален");
                }

            }
        }
    }
}
