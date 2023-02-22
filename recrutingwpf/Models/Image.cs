using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recrutingwpf
{
    public class Image
    {
        public int id { get; set; }
        public string imagepath { get; set; }
        public int appid { get; set; }
        public virtual Applicant App { get; set; }
       
    }
}
