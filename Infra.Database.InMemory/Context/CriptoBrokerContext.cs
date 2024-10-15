using Domain.Entities.Balance;
using Domain.Entities.Transaction;
using Infra.Database.InMemory.Util;
using Microsoft.EntityFrameworkCore;

namespace Infra.Database.InMemory.Context
{
    public class CriptoBrokerContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Balance> Balances { get; set; }
        
        
        
        
        public void CreateAndSeedTableBalance()
        {
         
            using (var context = new CriptoBrokerContext())
            {
                var sql = ExecuteEmbeddedResource.GetSqlScript("@Scripts.CREATE_TABLE_BALANCE.sql");
            }
        }
       
    }


    
}
