using FormacaoCSharp.CashFlow.Application.AutoMapper;
using FormacaoCSharp.CashFlow.Application.UseCases.Expenses.Delete;
using FormacaoCSharp.CashFlow.Application.UseCases.Expenses.GetAll;
using FormacaoCSharp.CashFlow.Application.UseCases.Expenses.GetById;
using FormacaoCSharp.CashFlow.Application.UseCases.Expenses.Register;
using FormacaoCSharp.CashFlow.Application.UseCases.Expenses.Reports.Excel;
using FormacaoCSharp.CashFlow.Application.UseCases.Expenses.Reports.Pdf;
using FormacaoCSharp.CashFlow.Application.UseCases.Expenses.Update;
using FormacaoCSharp.CashFlow.Application.UseCases.Login.DoLogin;
using FormacaoCSharp.CashFlow.Application.UseCases.Users.Register;
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
        services.AddScoped<IGenerateExpensesReportExcelUseCase, GenerateExpensesReportExcelUseCase>();
        services.AddScoped<IGenerateExpensesReportPdfUseCase, GenerateExpensesReportPdfUseCase>();
        services.AddScoped<IRegisterUserUseCase, RegisterUserUseCase>();
        services.AddScoped<IDoLoginUseCase, DoLoginUseCase>();
    }
}
