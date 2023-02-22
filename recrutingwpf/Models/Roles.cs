using System.Collections.Generic;

namespace recrutingwpf
{
    public class Roles
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Users> Users { get; set; }
    }
}
