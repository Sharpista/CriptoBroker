namespace Domain.Entities.Transaction
{
    public class Transaction
    {
        public Transaction(int userId, string transactionId, decimal amount, int type, 
                           string? currency, decimal amountInBrl, DateTime timestamp, string? description)
        {
            UserId = userId;
            TransactionId = transactionId;
            Amount = amount;
            Type = type;
            Currency = currency;
            AmountInBrl = amountInBrl;
            Timestamp = timestamp;
            Description = description;
        }

        public int UserId { get; private set; }
        public string TransactionId { get; private set; }
        public decimal Amount { get; private set; }
        public int Type { get; private set; }
        public string? Currency { get; private set; }
        public decimal AmountInBrl { get; private set; }
        public DateTime Timestamp { get; private set; }
        public string? Description { get; private set; }
    }
}
