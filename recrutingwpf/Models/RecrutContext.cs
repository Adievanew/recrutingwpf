using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace recrutingwpf.Models
{
    internal class RecrutContext :DbContext 
    {
        public DbSet<Users> users { get; set; }
        public DbSet<Roles> Roles { get; set; }

        public DbSet <Hirer> Hirers { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Response> Responses { get; set; }

        private static RecrutContext context;
        public static RecrutContext GetContext()
        {
            if (context == null)
                context = new RecrutContext();
            return context;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Entity<Users>()
        .HasOne(a => a.Applicant).WithOne(b => b.User)
        .HasForeignKey<Applicant>(e => e.Id);
            modelBuilder.Entity<Users>()
        .HasOne(a => a.Hirer).WithOne(b => b.User)
        .HasForeignKey<Hirer>(e => e.Id);
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Order>().Property(g => g.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            modelBuilder.Entity<Order>().HasMany(s => s.Responses).WithOne(a => a.OrderId);
            modelBuilder.Entity<Response >().ToTable("Response");
            modelBuilder.Entity<Response>().Property(g => g.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Dbrecrut;Username=postgres;Password=aiguladieva");
        }
    }
}
