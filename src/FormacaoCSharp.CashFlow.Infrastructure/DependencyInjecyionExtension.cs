using FormacaoCSharp.CashFlow.Domain.Repositories.Expenses;
using FormacaoCSharp.CashFlow.Infrastructure.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FormacaoCSharp.CashFlow.Infrastructure;

public static class DependencyInjecyionExtension
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IExpensesRepository, ExpensesRepository>();
    }
}
