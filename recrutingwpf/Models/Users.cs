using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recrutingwpf.Models
{
    internal class Users
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

        public string ImageAvatar { get; set; }

        public virtual Roles Role { get; set; }
        public Applicant Applicant { get; set; }
        public Hirer Hirer { get; set; }
    }
}
