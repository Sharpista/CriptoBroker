namespace Domain.Entities.Balance
{
    public class Balance
    {
        public Balance(int userId, decimal totalBalance)
        {
            UserId = userId;
            TotalBalance = totalBalance;
        }

        public Balance(decimal totalBalance)
        {
            TotalBalance = totalBalance;
        }

        public int UserId { get; private set; }
        public decimal TotalBalance { get; private set; }

        
    }
}
