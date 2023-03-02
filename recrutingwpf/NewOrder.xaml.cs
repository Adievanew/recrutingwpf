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
        internal Order order { get; set; }
        public int IdH;
        public NewOrder(int idorder, int idhirer)
        {
            InitializeComponent();
            order = RecrutContext.GetContext().orders.Where(p => p.id == idorder).FirstOrDefault();
            this.DataContext = order;
            IdH = idhirer;
        }
        public NewOrder (int idhirer)
        {
            InitializeComponent();
            order  = new Order ();
            this.DataContext = order ;
            IdH = idhirer;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            //try
            //{
                if (order.id == 0) RecrutContext.GetContext().orders.Add(order);
                order.hirerid = IdH;
                RecrutContext.GetContext().SaveChanges();
                MessageBox.Show("Изменения сохранены!");
            //}
            //catch
            //{
            //    MessageBox.Show("Заполните все необходимые поля");
            //}
        }
    }
}
