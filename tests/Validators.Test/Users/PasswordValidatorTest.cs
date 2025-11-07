using FluentAssertions;
using FluentValidation;
using FormacaoCSharp.CashFlow.Application.UseCases.Users;
using FormacaoCSharp.CashFlow.Communication.Requests;

namespace Validators.Test.Users;

public class PasswordValidatorTest
{
    [Theory]
    [InlineData("")]
    [InlineData("      ")]
    [InlineData(null)]
    [InlineData("a")]
    [InlineData("aa")]
    [InlineData("aaa")]
    [InlineData("aaaa")]
    [InlineData("aaaaa")]
    [InlineData("aaaaaa")]
    [InlineData("aaaaaaa")]
    [InlineData("aaaaaaaa")]
    [InlineData("AAAAAAAA")]
    [InlineData("Aaaaaaaa")]
    [InlineData("Aaaaaaa1")]
    public void Error_Password_Invalid(string password)
    {
        var validator = new PasswordValidator<RequestRegisterUserJson>();

        var result = validator
            .IsValid(new ValidationContext<RequestRegisterUserJson>(new RequestRegisterUserJson()), password);

        result.Should().BeFalse();
    }
}