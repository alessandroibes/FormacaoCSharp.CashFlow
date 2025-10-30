using FormacaoCSharp.CashFlow.Domain.Entities;
using FormacaoCSharp.CashFlow.Domain.Repositories.Expenses;

namespace FormacaoCSharp.CashFlow.Infrastructure.DataAccess.Repositories;

internal class ExpensesRepository : IExpensesRepository
{
    public void Add(Expense expense)
    {
        var dbContext = new CashFlowDbContext();

        dbContext.Expenses.Add(expense);

        dbContext.SaveChanges();
    }
}
