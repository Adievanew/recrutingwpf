using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace recrutingwpf.Models
{
    internal class Applicant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronomic { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Job { get; set; }
        public string Education { get; set; }

        public virtual Users User { get; set; }

        public List<Image> ImageId { get; set; }
        public List<Order> OrderId { get; set; }
        public List<Response> RespId { get; set; }
    }
}
