using Domain.Entities.Balance;
using Domain.Interfaces.Ports.Common;

namespace Infra.Database.InMemory.Repositories
{
    public class BalanceRepository : IBalanceRepository
    {
        public IEnumerable<Balance> GetBalance(int UserId, string? currency)
        {
            throw new NotImplementedException();
        }
    }
}
