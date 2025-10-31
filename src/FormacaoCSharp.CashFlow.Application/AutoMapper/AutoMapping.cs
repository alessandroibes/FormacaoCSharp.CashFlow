using AutoMapper;
using FormacaoCSharp.CashFlow.Communication.Requests;
using FormacaoCSharp.CashFlow.Communication.Responses;
using FormacaoCSharp.CashFlow.Domain.Entities;

namespace FormacaoCSharp.CashFlow.Application.AutoMapper;

public  class AutoMapping : Profile
{
    public AutoMapping()
    {
        RequestToEntity();
        EntityToResponse();
    }

    private void RequestToEntity()
    {
        CreateMap<RequestRegisterExpenseJson, Expense>();
    }

    private void EntityToResponse()
    {
        CreateMap<Expense, ResponseRegisteredExpenseJson>();
        CreateMap<Expense, ResponseShortExpenseJson>();
    }
}
