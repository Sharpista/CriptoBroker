using Domain.Entities.Transaction;

namespace Domain.Interfaces.Ports.Common.Repositories
{
    public interface ITransactionRepository
    {
        public Transaction CreditAsync(Transaction transaction);
        public Transaction DebitAsync(int userId, string currency, decimal amount);
        public IEnumerable<Transaction> GetTransactionsAsync(DateTime? from, DateTime? to);
    }
}
