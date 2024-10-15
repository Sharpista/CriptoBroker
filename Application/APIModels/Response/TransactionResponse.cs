namespace Application.APIModels.Response
{
    public class TransactionResponse
    {
        public string? TransactionId { get;  set; }
        public string? Currency { get;  set; }
        public decimal Amount { get;  set; }
        public int Type { get; set; }
        public decimal AmountInBrl { get;  set; }
        public DateTime Timestamp { get;  set; }
        public string? Description { get;  set; }
    }
}
