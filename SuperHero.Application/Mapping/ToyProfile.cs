using AutoMapper;
using SuperHero.Application.DTOs;
using SuperHero.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHero.Application.Mapping;

public class ToyProfile : Profile
{
    public ToyProfile()
    {
        CreateMap<Toy, ToyDto>();
        CreateMap<CreateToyDto, Toy>();
        CreateMap<UpdateToyDto, Toy>();
    }
}