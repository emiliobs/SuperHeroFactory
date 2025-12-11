using SuperHero.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHero.Application.Services;

public interface ISuperHeroService
{
    Task<IReadOnlyList<ToyDto>> GetAllAsync();

    Task<ToyDto?> GetByIdAsync(int id);

    Task<ToyDto> CreateAsync(CreateToyDto createToyDto);

    Task<bool> UpdateAsync(int id, UpdateToyDto updateToyDto);

    Task<bool> DeleteAsync(int id);
}