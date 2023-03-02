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

namespace recrutingwpf.Resourses 
{
    /// <summary>
    /// Логика взаимодействия для Orders.xaml
    /// </summary>
    public partial class Orders : Page
    {
        
       public int app;
        internal Response resp { get; set; } = new Response();
        public Orders(int id)
        {
            InitializeComponent();
            var currentOrders = RecrutContext.GetContext().orders.ToList();
            ListImage.ItemsSource = currentOrders;
            app = id;
             
        }

       


        private void Response_Click(object sender, RoutedEventArgs e)
        {
            if (ListImage.SelectedItem != null)
            {
                if (resp.id == 0)
                    RecrutContext.GetContext().response.Add(resp);

                resp.idapp  = app;
                resp.Order  = ListImage.SelectedItem as Order;
                resp.OrderId  = (ListImage.SelectedItem as Order).hirerid;

                RecrutContext.GetContext().SaveChanges();
                MessageBox.Show("Резюме доставлено");

            }
            
        }
    }
}
