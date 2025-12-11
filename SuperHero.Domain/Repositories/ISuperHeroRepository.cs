using SuperHero.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHero.Domain.Repositories;

public interface ISuperHeroRepository
{
    Task<List<Toy>> GetAllAsync();

    Task<Toy?> GetByIdAsync(int id);

    Task AddAsync(Toy toy);

    Task UpdateAsync(Toy toy);

    Task DeleteAsync(Toy toy);
}