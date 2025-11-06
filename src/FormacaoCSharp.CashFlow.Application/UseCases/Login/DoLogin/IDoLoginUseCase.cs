using FormacaoCSharp.CashFlow.Communication.Requests;
using FormacaoCSharp.CashFlow.Communication.Responses;

namespace FormacaoCSharp.CashFlow.Application.UseCases.Login.DoLogin;

public interface IDoLoginUseCase
{
    Task<ResponseRegisteredUserJson> Execute(RequestLoginJson request);
}