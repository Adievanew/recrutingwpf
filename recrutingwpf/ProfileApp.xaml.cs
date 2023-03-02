using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;


namespace recrutingwpf
{
    /// <summary>
    /// Логика взаимодействия для ProfileApp.xaml
    /// </summary>
    public partial class ProfileApp : Page
    {
       
        internal Applicant User { get; set; }
        public ProfileApp(int id)
        {
            InitializeComponent();
            User = RecrutContext.GetContext().applicant.Where(p => p.id == id).FirstOrDefault();
            this.DataContext = User;
            
        }

      

        private void EditImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png;";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                string s = Environment.CurrentDirectory;

                File.Copy(openFileDialog.FileName, @"C:\Users\Aigul\source\repos\recrutingwpf\recrutingwpf\Resourses\" + System.IO.Path.GetFileName(openFileDialog.FileName));
                User.imageavatar = System.IO.Path.GetFullPath (openFileDialog.FileName);
                this.DataContext = null;
                this.DataContext = User;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (User.id == 0) RecrutContext.GetContext().applicant.Add(User);
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
