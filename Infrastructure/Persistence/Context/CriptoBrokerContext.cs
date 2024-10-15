using Domain.Entities.Balance;
using Domain.Entities.Transaction;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Context
{
    public class CriptoBrokerContext : DbContext
    {
        public CriptoBrokerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Balance> Balances { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BalanceEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionEntityTypeConfiguration());

            SeedBalance(modelBuilder);

        }

        public void SeedBalance(ModelBuilder modelBuilder)
        {
            Balance balance = new Balance(1,1000);

            modelBuilder.Entity<Balance>().HasData(balance);
        }

        
    }



}
