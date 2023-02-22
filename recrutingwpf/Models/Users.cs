namespace recrutingwpf
{
    public class Users
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int roleid { get; set; }     

        public virtual Roles Role { get; set; }
        public virtual Applicant Applicant { get; set; }
        public virtual Hirer Hirer { get; set; }
    }
}
