namespace RPG.Items
{
    internal class Weapon : Item
    {
        public enum Types
        {
            Axes,
            Bows,
            Daggers,
            Hammers,
            Staffs,
            Swords,
            Wands,
            Null
        }
        public Types Type { get; set; } = Types.Null;
        public int Damage { get; set; } = 0;
        public int Speed { get; set; } = 0;
    }
}
