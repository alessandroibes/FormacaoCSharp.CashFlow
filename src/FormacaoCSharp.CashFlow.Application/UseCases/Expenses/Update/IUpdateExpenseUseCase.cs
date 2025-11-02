using FormacaoCSharp.CashFlow.Communication.Requests;

namespace FormacaoCSharp.CashFlow.Application.UseCases.Expenses.Update;

public interface IUpdateExpenseUseCase
{
    Task Execute(long id, RequestExpenseJson request);
}