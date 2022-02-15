using RPG.Items;
using RPG.Types;

namespace RPG.Charecters;

public abstract class Charecter
{
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; } = 1;
    public PrimaryAttributes BasePrimaryAttributes { get; set; } = new PrimaryAttributes();
    private PrimaryAttributes TotalPrimaryAttributes { get; set; } = new PrimaryAttributes();
    public abstract void LevelUp();
    public abstract void EquipItem(Item item);
    public abstract double GetDamage();
    public PrimaryAttributes GetTotalAttributes()
    { 
        return TotalPrimaryAttributes; 
    }
    public string GetCharecterStats()
    {
        string stats = string.Empty;
        GetTotalAttributes();
        return stats;
    }
}
