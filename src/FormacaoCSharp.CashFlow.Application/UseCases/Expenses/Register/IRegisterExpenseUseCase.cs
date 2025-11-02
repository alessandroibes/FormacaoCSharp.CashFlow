using FormacaoCSharp.CashFlow.Communication.Requests;
using FormacaoCSharp.CashFlow.Communication.Responses;

namespace FormacaoCSharp.CashFlow.Application.UseCases.Expenses.Register;

public interface IRegisterExpenseUseCase
{
    Task<ResponseRegisteredExpenseJson> Execute(RequestExpenseJson request);
}
