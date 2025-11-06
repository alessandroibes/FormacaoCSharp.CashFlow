using FormacaoCSharp.CashFlow.Domain.Entities;
using FormacaoCSharp.CashFlow.Domain.Repositories.User;
using Microsoft.EntityFrameworkCore;

namespace FormacaoCSharp.CashFlow.Infrastructure.DataAccess.Repositories;

internal class UserRepository : IUserReadOnlyRepository, IUserWriteOnlyRepository
{
    private readonly CashFlowDbContext _dbContext;

    public UserRepository(CashFlowDbContext dbContext) => _dbContext = dbContext;

    public async Task Add(User user)
    {
        await _dbContext.Users.AddAsync(user);
    }

    public async Task<bool> ExistActiveUserWithEmail(string email)
    {
        return await _dbContext.Users.AnyAsync(user => user.Email.Equals(email));
    }

    public Task<User?> GetUserByEmail(string email)
    {
        throw new NotImplementedException();
    }
}