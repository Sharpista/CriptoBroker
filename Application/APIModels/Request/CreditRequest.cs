namespace Application.APIModels.Request
{
    public class CreditRequest
    {
        public int UserId { get; set; }
        public string? Currency { get; set; }
        public decimal Amount { get; set; }
    }
}
