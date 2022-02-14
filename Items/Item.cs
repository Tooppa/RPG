using RPG.Types;

namespace RPG.Items
{
    public class Item
    {
        public string Name { get; set; } = string.Empty;
        public int RequredLevel { get; set; } = 0;
        public Slot Slot { get; set; } = Slot.Null;
    }
}
