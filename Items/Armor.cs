using RPG.Types;

namespace RPG.Items
{
    internal class Armor : Item
    {
        public ArmorType Type { get; set; } = ArmorType.Null;
    }
}
