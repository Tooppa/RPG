using RPG.Items;
using RPG.Types;
namespace RPG.Charecters;

public abstract class Charecter
{
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; } = 1;
    public PrimaryAttributes BasePrimaryAttributes { get; set; } = new PrimaryAttributes();
    private PrimaryAttributes TotalPrimaryAttributes { get; set; } = new PrimaryAttributes();
    public Dictionary<Slot, Item> Items { get; set; } = new Dictionary<Slot, Item>{
        { Slot.Head, new Armor() },
        { Slot.Body, new Armor() },
        { Slot.Legs, new Armor() },
        { Slot.Weapon, new Weapon() }
    };
    public abstract void LevelUp();
    public abstract string EquipWeapon(Weapon weapon);
    public abstract string EquipArmor(Armor armor);
    public abstract double GetDamage();
    public PrimaryAttributes GetTotalAttributes()
    {
        TotalPrimaryAttributes = BasePrimaryAttributes;
        return TotalPrimaryAttributes; 
    }
    public string GetCharecterStats()
    {
        string stats = string.Empty;
        GetTotalAttributes();
        return stats;
    }
}
