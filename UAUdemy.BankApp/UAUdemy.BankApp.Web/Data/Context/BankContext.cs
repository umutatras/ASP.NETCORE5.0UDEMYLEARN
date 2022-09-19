using Microsoft.EntityFrameworkCore;
using UAUdemy.BankApp.Web.Data.Configurations;
using UAUdemy.BankApp.Web.Data.Entities;

namespace UAUdemy.BankApp.Web.Data.Context
{
    public class BankContext:DbContext
    {
        public DbSet<Account> Account { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
