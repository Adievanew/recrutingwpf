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
    /// Логика взаимодействия для MyResponses.xaml
    /// </summary>
    public partial class MyResponses : Page
    {
        internal Hirer hirer { get; set; }
        public int app;
        internal Response resp { get; set; } = new Response();
        public MyResponses(int id)
        {
            InitializeComponent();
            var currentOrders = RecrutContext.GetContext().response.Where(p => p.idapp== id).ToList(); ;
            ListImage.ItemsSource = currentOrders;
            app = id;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ListImage.SelectedItem != null)
            {
                Response response = ListImage.SelectedItem as Response;
                if (response.id != 0)
                {
                    RecrutContext.GetContext().response.Remove(response);
                    RecrutContext.GetContext().SaveChanges();
                    MessageBox.Show("Отклик удален");
                }

            }

        }
    }
}
