using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recrutingwpf
{
    public class Order
    {
        public int id { get; set; }
        public string name { get; set; }
        public int paymentcost { get; set; }
        public string description { get; set; }
        public int hirerid { get; set; }
        public virtual Hirer Hirer { get; set; }
        public virtual List<Response> Responses { get; set; } = new List<Response>();
    }
}
