using Microsoft.EntityFrameworkCore;
using RestAPi.DataModels;
using System.Configuration;


namespace RestAPi
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Email> Emails { get; set; }

        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            try
            {
                
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=CodeFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //optionsBuilder.UseLazyLoadingProxies();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>().HasOne(e => e.pessoa).WithMany(e => e.emails).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
