using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace recrutingwpf
{
    internal class RecrutContext : DbContext
    {
        public RecrutContext() {}
        public DbSet<Users> users { get; set; }
        public DbSet<Roles> roles { get; set; }

        public DbSet <Hirer> hirer { get; set; }
        public DbSet<Applicant> applicant { get; set; }
        public DbSet<Image> image { get; set; }
        public DbSet<Order> orders { get; set; }

        public DbSet<Response> response { get; set; }

        private static RecrutContext context;
        public static RecrutContext GetContext()
        {
            if (context == null)
                context = new RecrutContext();
            return context;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("public");
            //modelBuilder.Entity<Users>().HasOne(a => a.Applicant).WithOne(b => b.User).HasForeignKey<Applicant>(e => e.id);
            //modelBuilder.Entity<Users>().HasOne(a => a.Hirer).WithOne(b => b.User).HasForeignKey<Hirer>(e => e.id);
            //modelBuilder.Entity<Order>().ToTable("orders");
            //modelBuilder.Entity<Order>().Property(g => g.id).ValueGeneratedOnAdd().UseIdentityColumn();
            //modelBuilder.Entity<Order>().HasMany(s => s.Responses).WithOne(a => a.Order);
            //modelBuilder.Entity<Response>().ToTable("response");
            //modelBuilder.Entity<Response>().Property(g => g.id).ValueGeneratedOnAdd().UseIdentityColumn();
            //modelBuilder.Entity<Applicant>().HasMany(s => s.Images).WithOne(a => a.App);
            //modelBuilder.Entity<Image>().ToTable("image");
            //modelBuilder.Entity<Image>().Property(g => g.id).ValueGeneratedOnAdd().UseIdentityColumn();
            //modelBuilder.Entity<Applicant>().HasMany(s => s.Responses).WithOne(a => a.App);
            //modelBuilder.Entity<Response>().ToTable("response");
            //modelBuilder.Entity<Response>().Property(g => g.id).ValueGeneratedOnAdd().UseIdentityColumn();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User Id=postgres;Password=aiguladieva;Database=DBrecrut_1");
        }
    }
}
