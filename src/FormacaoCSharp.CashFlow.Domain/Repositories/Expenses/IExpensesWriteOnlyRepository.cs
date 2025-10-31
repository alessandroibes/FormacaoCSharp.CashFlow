using FormacaoCSharp.CashFlow.Domain.Entities;

namespace FormacaoCSharp.CashFlow.Domain.Repositories.Expenses;

public interface IExpensesWriteOnlyRepository
{
    Task Add(Expense expense);
}