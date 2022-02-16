using RPG.Types;

namespace RPG.Items
{
    public abstract class Item
    {
        public string Name { get; set; } = string.Empty;
        public int RequiredLevel { get; set; } = 0;
        public Slot Slot { get; set; } = Slot.Null;
    }
}
