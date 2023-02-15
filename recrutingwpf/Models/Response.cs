using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace recrutingwpf.Models
{
    internal class Response
    {
        public int Id { get; set; }
        public int IdApp { get; set; }
        public int IdOrder { get; set; }
        public virtual Applicant AppId { get; set; }
        public virtual Order OrderId { get; set; }
    }
}
