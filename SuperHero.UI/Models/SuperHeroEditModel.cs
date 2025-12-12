using System.ComponentModel.DataAnnotations;

namespace SuperHero.UI.Models;

public class SuperHeroEditModel
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

    [Display(Name = "Firts Appearance")]
    [DataType(DataType.Date)]
    public DateOnly? FirstAppearance { get; set; }
}