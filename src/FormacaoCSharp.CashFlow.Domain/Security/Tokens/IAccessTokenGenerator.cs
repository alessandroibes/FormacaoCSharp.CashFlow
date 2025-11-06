using FormacaoCSharp.CashFlow.Domain.Entities;

namespace FormacaoCSharp.CashFlow.Domain.Security.Tokens;

public interface IAccessTokenGenerator
{
    string Generate(User user);
}