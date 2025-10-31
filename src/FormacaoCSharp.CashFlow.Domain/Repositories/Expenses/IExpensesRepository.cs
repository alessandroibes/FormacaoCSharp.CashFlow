using FormacaoCSharp.CashFlow.Domain.Entities;

namespace FormacaoCSharp.CashFlow.Domain.Repositories.Expenses;

public interface IExpensesRepository
{
    Task Add(Expense expense);
    Task<List<Expense>> GetAll();
}
