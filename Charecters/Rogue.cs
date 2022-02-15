using RPG.Items;

namespace RPG.Charecters
{
    public class Rogue : Charecter
    {
        public Rogue()
        {
            BasePrimaryAttributes.Dexterity = 6;
            BasePrimaryAttributes.Intelligence = 1;
            BasePrimaryAttributes.Strenght = 2;
        }

        public override void EquipItem(Item item)
        {
            throw new NotImplementedException();
        }

        public override double GetDamage()
        {
            throw new NotImplementedException();
        }

        public override void LevelUp()
        {
            Level += 1;
            BasePrimaryAttributes.Dexterity += 4;
            BasePrimaryAttributes.Intelligence += 1;
            BasePrimaryAttributes.Strenght += 1;
        }
    }
}
