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
    /// Логика взаимодействия для NewOrder.xaml
    /// </summary>
    public partial class NewOrder : Page
    {
        internal Response response { get; set; }
        public NewOrder(int id)
        {
            InitializeComponent();
            response  = RecrutContext.GetContext().response.Where(p => p.id == id).FirstOrDefault();
            this.DataContext = response;
        }
        public NewOrder ()
        {
            InitializeComponent();
            response  = new Response ();
            this.DataContext = response ;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (response.id == 0) RecrutContext.GetContext().response.Add(response );
            try
            {
                RecrutContext.GetContext().SaveChanges();
                MessageBox.Show("Изменения сохранены!");
            }
            catch
            {
                MessageBox.Show("Заполните все необходимые поля");
            }
        }
    }
}
