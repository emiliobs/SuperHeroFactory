using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SuperHero.Application.DTOs;

public class CreateToyDto
{
    [Required(ErrorMessage = "Real name is required.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Real name must be between 2 and 100 characters.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Alias is required.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Alias must be between 2 and 100 characters.")]
    public string Alias { get; set; } = string.Empty;

    [Display(Name = "Main Power")]
    [Required(ErrorMessage = "Main power is required.")]
    [StringLength(150, MinimumLength = 3, ErrorMessage = "Main power must be between 3 and 150 characters.")]
    public string MainPower { get; set; } = string.Empty;

    [Display(Name = "Power Level")]
    [Range(1, 100, ErrorMessage = "Power level must be between 1 and 100.")]
    public int PowerLevel { get; set; } = 50;

    [Display(Name = "First appearance")]
    [DataType(DataType.Date, ErrorMessage = "First appearance must be a valid date.")]
    public DateOnly? FirstAppearance { get; set; }
}