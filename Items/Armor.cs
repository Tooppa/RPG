namespace RPG.Items
{
    internal class Armor : Item
    {
        public enum Types
        {
            Cloth,
            Leather,
            Mail,
            Plate,
            Null
        }
        public Types Type { get; set; } = Types.Null;
    }
}
