using Bogus;
using FormacaoCSharp.CashFlow.Communication.Enums;
using FormacaoCSharp.CashFlow.Communication.Requests;

namespace CommonTestUtilities.Requests;

public class RequestRegisterExpenseJsonBuilder
{
    public RequestRegisterExpenseJson Build()
    {
        return new Faker<RequestRegisterExpenseJson>()
            .RuleFor(r => r.Title, faker => faker.Commerce.ProductName())
            .RuleFor(r => r.Description, faker => faker.Commerce.ProductDescription())
            .RuleFor(r => r.Date, faker => faker.Date.Past())
            .RuleFor(r => r.PaymentType, faker => faker.PickRandom<PaymentType>())
            .RuleFor(r => r.Amount, faker => faker.Random.Decimal(min: 1, max: 1000));
    }
}
