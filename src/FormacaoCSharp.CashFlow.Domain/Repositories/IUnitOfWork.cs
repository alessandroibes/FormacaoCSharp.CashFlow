namespace FormacaoCSharp.CashFlow.Domain.Repositories;

public interface IUnitOfWork
{
    Task Commit();
}
