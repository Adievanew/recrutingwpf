using Microsoft.Win32;
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

namespace recrutingwpf
{
    /// <summary>
    /// Логика взаимодействия для MyImages.xaml
    /// </summary>
    public partial class MyImages : Page
    {
        internal List<Image> images { get; set; }
        internal Image image { get; set; } = new Image();
        int Id;
        public MyImages(int id)
        {
            InitializeComponent();
            var currentImages = RecrutContext.GetContext().image.ToList();//Where(p => p.appid  == id).ToList();
            ListImage.ItemsSource = currentImages;
            Id=id;
            
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png;";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                string s = Environment.CurrentDirectory;

                File.Copy(openFileDialog.FileName, @"C:\Users\Aigul\source\repos\recrutingwpf\recrutingwpf\Resourses1\" + System.IO.Path.GetFileName(openFileDialog.FileName));
                
                
                image.imagepath = System.IO.Path.GetFileName(openFileDialog.FileName);
                image.appid = Id;
                this.DataContext = null;
                this.DataContext = RecrutContext.GetContext().image.ToList();//Where(p => p.appid  == id).ToList();;

                if (image.id == 0)
                {
                    RecrutContext.GetContext().image.Add(image);
                    RecrutContext.GetContext().SaveChanges();
                    MessageBox.Show("Изображение успешно сохранено");
                }
                this.DataContext = null;
                ListImage.ItemsSource = null;
                ListImage.ItemsSource = RecrutContext.GetContext().image.Where(p => p.appid  == Id).ToList();;

            }
        }
    }
}
