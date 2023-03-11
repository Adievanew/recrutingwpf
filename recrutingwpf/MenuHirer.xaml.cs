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
using System.Windows.Shapes;

namespace recrutingwpf
{
    /// <summary>
    /// Логика взаимодействия для MenuHirer.xaml
    /// </summary>
    public partial class MenuHirer : Window
    {
        public static Frame Frame { get; set; }
        int Id;
        public MenuHirer(int id)
        {
            InitializeComponent();
            Frame = mainFrame;
            Id = id;
        }

        private void Profile_Checked(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new PrfileHirer(Id));
        }

        private void Profile1_Checked(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Myorders(Id));
        }

        private void Profile2_Checked(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Myresponces(Id)); 
        }


        private void Profile4_Checked(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow m = new MainWindow();
            m.Show();
        }

       
    }
}
