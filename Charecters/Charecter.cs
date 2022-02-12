namespace RPG.Charecters;

internal abstract class Charecter
{
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; } = 1;
    public int BaseStrenght { get; set; } = 1;
    public int BaseDexterity { get; set; } = 1;
    public int BaseIntelligence { get; set; } = 1;
    public int TotalStrenght { get; set; } = 1;
    public int TotalDexterity { get; set; } = 1;
    public int TotalIntelligence { get; set; } = 1;
    public abstract void LevelUp();
}
