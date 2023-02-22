using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace recrutingwpf
{
    public class Response
    {
        public int id { get; set; }
        public int idapp { get; set; }
        public int OrderId { get; set; }
        public virtual Applicant App { get; set; }
        public virtual Order Order { get; set; }
    }
}
