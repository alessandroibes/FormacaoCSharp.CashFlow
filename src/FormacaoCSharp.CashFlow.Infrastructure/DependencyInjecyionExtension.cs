using FormacaoCSharp.CashFlow.Domain.Repositories.Expenses;
using FormacaoCSharp.CashFlow.Infrastructure.DataAccess;
using FormacaoCSharp.CashFlow.Infrastructure.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FormacaoCSharp.CashFlow.Infrastructure;

public static class DependencyInjecyionExtension
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        AddDbContext(services);
        AddRepositories(services);
    }

    private static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped<IExpensesRepository, ExpensesRepository>();
    }

    private static void AddDbContext(IServiceCollection services)
    {
        services.AddDbContext<CashFlowDbContext>();
    }
}
