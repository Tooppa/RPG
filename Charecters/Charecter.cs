namespace RPG.Charecters;

internal abstract class Charecter
{
    string name { get; set; } = string.Empty;
    int level { get; set; } = 0;
    int baseStrenght { get; set; } = 0;
    int baseDexterity { get; set; } = 0;
    int baseIntelligence { get; set; } = 0;
    int totalStrenght { get; set; } = 0;
    int totalDexterity { get; set; } = 0;
    int totalIntelligence { get; set; } = 0;
    public abstract void LevelUp(int strength, int dexterity, int intelligence);
}
