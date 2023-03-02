
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow  : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

            private void voitiBtn_Click(object sender, RoutedEventArgs e)
            {
                if (loginTB.Text != "" && parolTB.Text != "")
                {
                    Users user = RecrutContext.GetContext().users.Where(p => p.login == loginTB.Text).FirstOrDefault();
                    if (user != null)
                    {


                        if (user.password == parolTB.Text)
                        {
                            if (user.roleid == 1)
                            {
                            Global.glavWin = new MenuWindow (user.id );
                            Global.glavWin.Show();
                            this.Close();
                        }
                            if (user.roleid == 2)
                            {

                            Global.glawWindow = new MenuHirer(user.id);
                            Global.glawWindow.Show();
                            this.Close();
                        }
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


