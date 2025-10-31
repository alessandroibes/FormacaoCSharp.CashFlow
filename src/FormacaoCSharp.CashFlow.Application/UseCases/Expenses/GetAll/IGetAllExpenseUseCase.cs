using FormacaoCSharp.CashFlow.Communication.Responses;

namespace FormacaoCSharp.CashFlow.Application.UseCases.Expenses.GetAll;

public interface IGetAllExpenseUseCase
{
    Task<ResponseExpensesJson> Execute();
}
