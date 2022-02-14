using RPG.Types;

namespace RPG.Items
{
    public class Weapon : Item
    {
        public WeaponType Type { get; set; } = WeaponType.Null;
        public int Damage { get; set; } = 0;
        public int Speed { get; set; } = 0;
    }
}
