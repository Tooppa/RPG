using RPG.Types;

namespace RPG.Charecters;

public abstract class Charecter
{
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; } = 1;
    public PrimaryAttributes BasePrimaryAttributes { get; set; } = new PrimaryAttributes();
    public PrimaryAttributes TotalPrimaryAttributes { get; set; } = new PrimaryAttributes();
    public abstract void LevelUp();
}
