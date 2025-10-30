using FormacaoCSharp.CashFlow.Domain.Entities;

namespace FormacaoCSharp.CashFlow.Domain.Repositories.Expenses;

public interface IExpensesRepository
{
    void Add(Expense expense);
}
