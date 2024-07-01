using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using prov.Models;

namespace prov.Data
{
    public class ProvDbContext : IdentityDbContext<User>
    {
        

        public ProvDbContext()
        {
        }
        public ProvDbContext(DbContextOptions<ProvDbContext> options) : base(options)
        {
        }


        private DbSet<User> User { get; set; }
        private DbSet<BankAccount> BankAccount { get; set; }
        private DbSet<Category> Category { get; set; }
        private DbSet<Product> Product { get; set; }
        private DbSet<BankTransaction> BankTransaction { get; set; }
        private DbSet<Currency> Currency { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankAccount>().HasKey(x => x.Id);

           modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<Category>().HasKey(x => x.Id);
            modelBuilder.Entity<Product>().HasKey(x => x.Id);
            modelBuilder.Entity<BankTransaction>().HasKey(x => x.Id);
            modelBuilder.Entity<Currency>().HasKey(x => x.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
