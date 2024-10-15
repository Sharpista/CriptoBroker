using Domain.Interfaces.Ports.Common.Repositories;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class InfrastructureModule
    {
        public static void AddInfraModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddContextInMemory(configuration);
            services.AddResolverDependency();
        }
        public static void AddContextInMemory(this IServiceCollection services, IConfiguration configuration)
            => services.AddDbContext<CriptoBrokerContext>(opt => opt.UseSqlServer(configuration["CRIPTO_BROKER"]));

        public static void AddResolverDependency(this IServiceCollection services)
        {
            services.AddTransient<ITransactionRepository, TransactionRepository>();
            services.AddTransient<IBalanceRepository, BalanceRepository>();
        }
    }
}
