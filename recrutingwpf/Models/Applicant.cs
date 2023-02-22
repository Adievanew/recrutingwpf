using System;
using System.Collections.Generic;

namespace recrutingwpf
{
    public class Applicant
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string patronomic { get; set; }
        public DateTime birthday { get; set; }
        public string email { get; set; }
        public string description { get; set; }
        public string job { get; set; }
        public string education { get; set; }

        public string imageavatar { get; set; }

        public int UserId { get; set; }

        public virtual Users User { get; set; }

        public virtual List<Image> Images { get; set; }
        
        public virtual List<Response> Responses { get; set; }
    }
}
