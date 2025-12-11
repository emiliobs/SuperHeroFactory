using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHero.Application.DTOs;

public class ToyDto
{
    public int id { get; set; }
    public string Name { get; set; } = string.Empty;

    public string Alias { get; set; } = string.Empty;

    public string MainPower { get; set; } = string.Empty;

    public int PowerLivel { get; set; }

    public DateOnly? FirstAppearance { get; set; }
}