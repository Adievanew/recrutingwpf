using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recrutingwpf.Models
{
    internal class Image
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public int AppId { get; set; }
        public virtual Applicant App { get; set; }
    }
}
