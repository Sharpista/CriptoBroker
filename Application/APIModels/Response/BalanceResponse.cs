namespace Application.APIModels.Response
{
    public class BalanceResponse
    {
        public int UserId { get; set; }
        public decimal TotalBalance { get; set; }
        public decimal TotalBalanceInBrl { get; set; }
        public string? Currency { get; set; }
    }
}
