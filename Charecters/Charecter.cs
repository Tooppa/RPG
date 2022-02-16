using RPG.Items;
using RPG.Types;
namespace RPG.Charecters;

public abstract class Charecter
{
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; } = 1;
    public PrimaryAttributes BasePrimaryAttributes { get; set; } = new PrimaryAttributes();
    public PrimaryAttributes TotalPrimaryAttributes { get; set; } = new PrimaryAttributes();
    public Dictionary<Slot, Armor> Items { get; set; } = new Dictionary<Slot, Armor>{
        { Slot.Head, new Armor() },
        { Slot.Body, new Armor() },
        { Slot.Legs, new Armor() }
    };
    public Weapon? Weapon { get; set; }
    public abstract void LevelUp();
    public abstract string EquipWeapon(Weapon weapon);
    public abstract string EquipArmor(Armor armor);
    public abstract double GetDamage();
    public PrimaryAttributes GetTotalAttributes()
    {
        TotalPrimaryAttributes = BasePrimaryAttributes;
        TotalPrimaryAttributes.AddStats(Items);
        return TotalPrimaryAttributes; 
    }
    public string GetCharecterStats()
    {
        string stats = string.Empty;
        GetTotalAttributes();
        return stats;
    }
}
