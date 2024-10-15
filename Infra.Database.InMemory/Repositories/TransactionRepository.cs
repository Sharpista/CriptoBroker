using Domain.Entities.Transaction;
using Domain.Interfaces.Ports.Common;

namespace Infra.Database.InMemory.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        public Transaction CreditAsync(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Transaction DebitAsync(int userId, string currency, decimal amount)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transaction> GetTransactionsAsync(DateTime? from, DateTime? to)
        {
            throw new NotImplementedException();
        }
    }
}
