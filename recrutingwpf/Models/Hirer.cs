namespace recrutingwpf
{
    public class Hirer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
        public string description { get; set; }
        public string email { get; set; }
        public string imageavatar { get; set; }

        public int UserId { get; set; }
        public virtual Users User { get; set; }
    }
}
