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

namespace recrutingwpf
{
    /// <summary>
    /// Логика взаимодействия для Myorders.xaml
    /// </summary>
    public partial class Myorders : Page
    {
        public static Frame Frame { get; set; }
        public  int Id;
        public Order order { get; set; }
        public Myorders(int id)
        {
            InitializeComponent();
            var currentOrders = RecrutContext.GetContext().orders.Where(p => p.hirerid  == id).ToList(); ;
            ListImage.ItemsSource = currentOrders;
            Id= id;

        }


        

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Global.glawWindow.mainFrame.Navigate(new NewOrder(Id));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ListImage.SelectedItem != null)
            {
                Order orderr = ListImage.SelectedItem as Order;
                if (orderr.id != 0)
                    Global.glawWindow.mainFrame.Navigate(new NewOrder(order.id, Id));

            }

        }
    }
}
