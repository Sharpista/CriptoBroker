using Domain.Interfaces.Ports.Common;
using Infra.Database.InMemory.Context;
using Infra.Database.InMemory.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Database.InMemory.InfraDatabaseModule
{
    public static class DataBaseInMemoryModule
    {
        public static void AddInfraModule(this IServiceCollection services)
        {
            AddContextInMemory(services);
            AddResolverDependency(services);
        }
        public static void AddContextInMemory(this IServiceCollection services) 
            => services.AddDbContext<CriptoBrokerContext>(opt => opt.UseInMemoryDatabase("CRIPTO_BROKER"));

        public static void AddResolverDependency(this IServiceCollection services)
        {
            services.AddTransient<ITransactionRepository, TransactionRepository>();
            services.AddTransient<IBalanceRepository, BalanceRepository>();
        }
    }
}
