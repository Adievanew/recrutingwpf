using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recrutingwpf.Models
{
    internal class Hirer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public virtual Users User { get; set; }
    }
}
