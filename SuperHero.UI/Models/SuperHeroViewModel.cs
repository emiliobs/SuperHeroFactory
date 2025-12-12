namespace SuperHero.UI.Models;

public class SuperHeroViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Alias { get; set; } = string.Empty;
    public string MainPower { get; set; } = string.Empty;
    public int PowerLevel { get; set; }
    public DateOnly? FirstAppearance { get; set; }
}