using FormacaoCSharp.CashFlow.Application.AutoMapper;
using FormacaoCSharp.CashFlow.Application.UseCases.Expenses.Delete;
using FormacaoCSharp.CashFlow.Application.UseCases.Expenses.GetAll;
using FormacaoCSharp.CashFlow.Application.UseCases.Expenses.GetById;
using FormacaoCSharp.CashFlow.Application.UseCases.Expenses.Register;
using FormacaoCSharp.CashFlow.Application.UseCases.Expenses.Update;
using Microsoft.Extensions.DependencyInjection;

namespace FormacaoCSharp.CashFlow.Application;

public static class DependencyInjectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        AddAutoMapper(services);
        AddUseCases(services);
    }

    private static void AddAutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapping));
    }

    private static void AddUseCases(IServiceCollection services)
    {
        services.AddScoped<IRegisterExpenseUseCase, RegisterExpenseUseCase>();
        services.AddScoped<IGetAllExpenseUseCase, GetAllExpenseUseCase>();
        services.AddScoped<IGetExpenseByIdUseCase, GetExpenseByIdUseCase>();
        services.AddScoped<IDeleteExpenseUseCase, DeleteExpenseUseCase>();
        services.AddScoped<IUpdateExpenseUseCase, UpdateExpenseUseCase>();
    }
}
