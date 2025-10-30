﻿using FormacaoCSharp.CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FormacaoCSharp.CashFlow.Infrastructure.DataAccess;

internal class CashFlowDbContext : DbContext
{
    public CashFlowDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Expense> Expenses { get; set; }
}
