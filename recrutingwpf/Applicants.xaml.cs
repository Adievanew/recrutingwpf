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
    /// Логика взаимодействия для Applicants.xaml
    /// </summary>
    public partial class Applicants : Page
    {
        public Applicants(int idord)
        {
            InitializeComponent();
            var currentOrders = RecrutContext.GetContext().response.Where(p => p.OrderId  == idord).ToList(); ;
            ListImage.ItemsSource = currentOrders;
            
        }
       

       
    }
}
