namespace Application.APIModels.Response
{
    public class CreditResponse
    {
        public int Status { get; set; }
        public string? Currency { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountInBrl { get; set; }
        public string? TransactionId { get; set; }
    }
}
