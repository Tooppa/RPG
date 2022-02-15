using RPG.Items;

namespace RPG.Charecters
{
    public class Ranger : Charecter
    {
        public Ranger()
        {
            BasePrimaryAttributes.Dexterity = 7;
            BasePrimaryAttributes.Intelligence = 1;
            BasePrimaryAttributes.Strenght = 1;
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
            BasePrimaryAttributes.Dexterity += 5;
            BasePrimaryAttributes.Intelligence += 1;
            BasePrimaryAttributes.Strenght += 1;
        }
    }
}
