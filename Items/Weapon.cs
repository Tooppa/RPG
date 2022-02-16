using RPG.Types;

namespace RPG.Items
{
    public class Weapon : Item
    {
        public WeaponType Type { get; set; } = WeaponType.Null;
        public WeaponAttributes Attributes { get; set; } = new WeaponAttributes();
    }
}
