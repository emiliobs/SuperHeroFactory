using SuperHero.Domain.UnitOfWorks;
using SuperHero.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHero.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        this._context = context;
    }

    public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();
}