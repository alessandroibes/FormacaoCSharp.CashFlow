using FormacaoCSharp.CashFlow.Application.UseCases.Expenses.Register;
using FormacaoCSharp.CashFlow.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace FormacaoCSharp.CashFlow.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterExpenseJson request)
    {
        var useCase = new RegisterExpenseUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }
}
