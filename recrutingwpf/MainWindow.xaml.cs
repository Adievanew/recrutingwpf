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
using recrutingwpf.Models;

namespace recrutingwpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "DBrecrut";
        private static string Password = "aiguladieva";
        private static string Port = "5432";
        public MainWindow()
        {
            InitializeComponent();
            new AppData.Configuration();
            string connString =
                String.Format(
                    "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};SSLMode=Prefer",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);
        }

        private void voitiBtn_Click(object sender, RoutedEventArgs e)
        {
            if (loginTB.Text != "" && parolTB.Text != "")
            {
                Users user = RecrutContext.GetContext().users.Where(p => p.Login == loginTB.Text).FirstOrDefault();
                if (user != null)
                {

                    if (user.Password == parolTB.Text)
                    {
                        Profile a = new Profile();
                        a.Show();
                    }
                    else
                    {
                            
                            MessageBox.Show("Неправильный пароль");
                    }
                }
                else
                {
                 MessageBox.Show("Вход заблокирован");
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин");
            }
        }

        }
    }

