using Domain.Entities.Balance;

namespace Domain.Interfaces.Ports.Common.Repositories
{
    public interface  IBalanceRepository
    {
        public IEnumerable<Balance> GetBalance(int UserId, string? currency);
    }
}
