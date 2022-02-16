using RPG.Items;
using RPG.Types;
using RPG.Execptions;
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
    /// <summary>
    /// Level ups the charecter and increses attributes
    /// </summary>
    public abstract void LevelUp();
    /// <summary>
    /// Equips the weapon thats passed to the charecter
    /// </summary>
    /// <param name="weapon"></param>
    /// <returns>
    /// Returns Weapon Success if it compleated
    /// </returns>
    /// <exception cref="InvalidWeaponException">When the weapon is invalid type or the required level is too high</exception>
    public abstract string EquipWeapon(Weapon weapon);
    /// <summary>
    /// Equips the armor thats passed to the charecter
    /// </summary>
    /// <param name="armor"></param>
    /// <returns>
    /// Returns Armor Success if it compleated
    /// </returns>
    /// <exception cref="InvalidArmorException">When the armor is invalid type or the required level is too high</exception>
    public abstract string EquipArmor(Armor armor);
    /// <summary>
    /// Gets the damage value that the charecter will inflict. It scales with weapons, armor and charecter level.
    /// </summary>
    /// <returns>
    /// Return the amount of damage as a double
    /// </returns>
    public abstract double GetDamage();
    /// <summary>
    /// Updates the totalAttributes values
    /// </summary>
    /// <returns>
    /// the updated totalAttributes
    /// </returns>
    public PrimaryAttributes GetTotalAttributes()
    {
        TotalPrimaryAttributes = BasePrimaryAttributes;
        TotalPrimaryAttributes.AddStats(Items);
        return TotalPrimaryAttributes; 
    }
    /// <summary>
    /// Return the stats of the charecter
    /// </summary>
    /// <returns>
    /// The stats are returned as a string
    /// </returns>
    public string GetCharecterStats()
    {
        string stats = string.Empty;
        stats += "Attributes";
        stats += GetTotalAttributes().ToString();
        stats += " Damage: ";
        stats += GetDamage();
        return stats;
    }
}
