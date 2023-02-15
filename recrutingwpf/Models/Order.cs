using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recrutingwpf.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PaymentCost { get; set; }
        public string Description { get; set; }
        public int HirerId { get; set; }
        public virtual Hirer Hirer { get; set; }

        public List<Response> Responses { get; set; }
    }
}
