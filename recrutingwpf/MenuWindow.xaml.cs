using recrutingwpf.Resourses;
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
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public static Frame Frame { get; set; }
        int Id;
        public MenuWindow(int id)
        {
            InitializeComponent();
            Frame = mainFrame;
            Id = id;
        }
        private void Profile_Checked(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ProfileApp(Id));
        }

        private void Profile1_Checked(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new MyImages(Id));
        }

        private void Profile2_Checked(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Orders(Id));
        }

        private void Profile3_Checked(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new MyResponses(Id)); 
        }

        private void Profile4_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }

      
    }
}
