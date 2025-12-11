using AutoMapper;
using SuperHero.Application.DTOs;
using SuperHero.Domain.Entities;
using SuperHero.Domain.Repositories;
using SuperHero.Domain.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHero.Application.Services;

public class SuperHeroService : ISuperHeroService
{
    private readonly ISuperHeroRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public SuperHeroService(ISuperHeroRepository repository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        this._repository = repository;
        this._unitOfWork = unitOfWork;
        this._mapper = mapper;
    }

    public async Task<IReadOnlyList<ToyDto>> GetAllAsync()
    {
        var heroes = await _repository.GetAllAsync();
        return _mapper.Map<List<ToyDto>>(heroes);
    }

    public async Task<ToyDto?> GetByIdAsync(int id)
    {
        var hero = await _repository.GetByIdAsync(id);
        return hero is null ? null : _mapper.Map<ToyDto>(hero);
    }

    public async Task<ToyDto> CreateAsync(CreateToyDto createToyDto)
    {
        var hero = _mapper.Map<Toy>(createToyDto);

        await _repository.AddAsync(hero);
        await _unitOfWork.SaveChangesAsync();

        return _mapper.Map<ToyDto>(hero);
    }

    public async Task<bool> UpdateAsync(int id, UpdateToyDto updateToyDto)
    {
        var hero = await _repository.GetByIdAsync(id);
        if (hero is null)
        {
            return false;
        }

        _mapper.Map(updateToyDto, hero);

        await _repository.UpdateAsync(hero);
        await _unitOfWork.SaveChangesAsync();

        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var hero = await _repository.GetByIdAsync(id);
        if (hero is null)
        {
            return false;
        }

        await _repository.DeleteAsync(hero);
        await _unitOfWork.SaveChangesAsync();

        return true;
    }
}