using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using System.Windows;
using Newtonsoft.Json;

namespace recrutingwpf.AppData
{
    public class Configuration
    {
        private string filename = "./app.json";
        public string Host { get; set; }
        public string Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Base { get; set; }

        public Configuration(string filename="./app.json")
        {
            this.filename = filename; 
            try
            {
                FileStream file = File.OpenRead(filename);
                if(file !=null)
                {
                    byte[] data = new byte[file.Length+1];
                  int filebytes=  file.Read (data, 0, data.Length);
                    file.Close();
                    if(filebytes == 0 || filebytes != data.Length ) 
                    {  //Создать файл с конфигурацией по умолчанию
                        return;
                    }
                    Configuration conf = JsonConvert.DeserializeObject<Configuration>(Encoding.Default.GetString(data));
                    if (conf != null)
                    {
                        Host = conf.Host;
                        Port = conf.Port;
                        User = conf.User;
                        Password = conf.Password;
                        Base = conf.Base;

                    }
                    else { MessageBox.Show("Файл конфигурации имел ненверный формат", "Внимание!", MessageBoxButton.OK); }
                }
                else
                {

                }
            }
            catch(Exception e) { MessageBox.Show(e.Message, "Внимание!", MessageBoxButton.OK);  }
        }
         public void Default()
        {
            Host= "localhost";
            Port = "5432";
            User= "postgres";
            Password = "aiguladieva";
            Base= "recrutdb";

        }
        public void Save()
        {
            try
            {
                string jsonObject=JsonConvert .SerializeObject(this);
                byte[] bytes = Encoding.Default.GetBytes(jsonObject);
                FileStream file = File.OpenWrite(filename);
          file.Write (Encoding.Default .GetBytes(jsonObject),0,bytes.Length );
                file.Close();
            }
            catch(Exception e)
            { MessageBox.Show(e.Message, "Ошибка!", MessageBoxButton.OK); }
        }


    }
}
