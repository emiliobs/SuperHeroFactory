using Microsoft.EntityFrameworkCore;
using SuperHero.Domain.Entities;
using SuperHero.Domain.Repositories;
using SuperHero.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHero.Infrastructure.Repositories;

public class SuperHeroRepository : ISuperHeroRepository
{
    private readonly AppDbContext _context;

    public SuperHeroRepository(AppDbContext context)
    {
        this._context = context;
    }

    public async Task<List<Toy>> GetAllAsync() => await _context.Toys.AsNoTracking().OrderBy(t => t.Alias).ToListAsync();

    public async Task<Toy?> GetByIdAsync(int id) => await _context.Toys.FindAsync(id);

    public async Task AddAsync(Toy toy) => await _context.Toys.AddAsync(toy);

    public async Task UpdateAsync(Toy toy) => _context.Toys.Update(toy);

    public async Task DeleteAsync(Toy toy) => _context.Toys.Remove(toy);
}