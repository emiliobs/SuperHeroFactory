using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHero.Domain.Entities;

public class Toy
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty; // Real name

    public string Alias { get; set; } = string.Empty; // Hero alias

    public string MainPower { get; set; } = string.Empty; // Main power or ability

    public int PowerLevel { get; set; } = 50; // Expected range: 1..100

    public DateOnly? FirstAppearance { get; set; } // Optional first appearance date
}