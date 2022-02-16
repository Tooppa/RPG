using RPG.Items;

namespace RPG.Types
{
    public class PrimaryAttributes
    {
        public int Strenght { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        /// <summary>
        /// Adds the passed dictionarys stats to the attributes
        /// </summary>
        /// <param name="armors"></param>
        public void AddStats(Dictionary<Slot, Armor> armors)
        {
            foreach (KeyValuePair<Slot,Armor> armor in armors)
            {
                Strenght += armor.Value.Attributes.Strenght;
                Dexterity += armor.Value.Attributes.Dexterity;
                Intelligence += armor.Value.Attributes.Intelligence;
            }
        }
    }
}
