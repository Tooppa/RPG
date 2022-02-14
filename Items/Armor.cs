using RPG.Types;

namespace RPG.Items
{
    public class Armor : Item
    {
        public ArmorType Type { get; set; } = ArmorType.Null;
        public PrimaryAttributes Attributes { get; set; } = new PrimaryAttributes();
    }
}
