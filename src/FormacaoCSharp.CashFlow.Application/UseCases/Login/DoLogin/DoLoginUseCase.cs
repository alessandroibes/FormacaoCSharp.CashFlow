using FormacaoCSharp.CashFlow.Communication.Requests;
using FormacaoCSharp.CashFlow.Communication.Responses;
using FormacaoCSharp.CashFlow.Domain.Repositories.User;
using FormacaoCSharp.CashFlow.Domain.Security.Cryptography;
using FormacaoCSharp.CashFlow.Domain.Security.Tokens;
using FormacaoCSharp.CashFlow.Exception.ExceptionsBase;

namespace FormacaoCSharp.CashFlow.Application.UseCases.Login.DoLogin;

public class DoLoginUseCase : IDoLoginUseCase
{
    private readonly IUserReadOnlyRepository _repository;
    private readonly IPasswordEncripter _passwordEncripter;
    private readonly IAccessTokenGenerator _accessTokenGenerator;

    public DoLoginUseCase(
        IUserReadOnlyRepository repository,
        IPasswordEncripter passwordEncripter,
        IAccessTokenGenerator accessTokenGenerator)
    {
        _passwordEncripter = passwordEncripter;
        _repository = repository;
        _accessTokenGenerator = accessTokenGenerator;
    }

    public async Task<ResponseRegisteredUserJson> Execute(RequestLoginJson request)
    {
        var user = await _repository.GetUserByEmail(request.Email);

        if (user is null)
        {
            throw new InvalidLoginException();
        }

        var passwordMatch = _passwordEncripter.Verify(request.Password, user.Password);

        if (passwordMatch == false)
        {
            throw new InvalidLoginException();
        }

        return new ResponseRegisteredUserJson
        {
            Name = user.Name,
            Token = _accessTokenGenerator.Generate(user)
        };
    }
}