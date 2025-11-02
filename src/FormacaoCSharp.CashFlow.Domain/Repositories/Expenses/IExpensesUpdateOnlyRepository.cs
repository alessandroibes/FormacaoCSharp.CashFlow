using FormacaoCSharp.CashFlow.Domain.Entities;

namespace FormacaoCSharp.CashFlow.Domain.Repositories.Expenses;

public interface IExpensesUpdateOnlyRepository
{
    Task<Expense?> GetById(long id);
    void Update(Expense expense);
}
